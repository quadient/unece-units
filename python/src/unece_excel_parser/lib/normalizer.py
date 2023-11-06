import re


class Normalizer:
    blacklisted_factors = [
        "use pair",  # NPR
        "-log10(mol/l)",  # Q30
        "mg KOH/g",  # TAN
        "10^[Power in dBW/10] W",  # DBW
        "10^[(Power in dBm-30)/10] W"  # DBM
    ]

    unit_transformations = {"'": "arcsec", "\"": "arcmin", "kW·h/h": "kWh/h"}

    @staticmethod
    def is_empty(text: any) -> bool:
        return text is None or str(text) == "nan" or str(text).strip() == ""

    @staticmethod
    def normalize_value(value: str) -> str | None:
        if Normalizer.is_empty(value):
            return None

        return str(value).strip()

    @staticmethod
    def normalize_unit_name(name) -> str | None:
        normalized_name = Normalizer.normalize_value(name)
        if normalized_name is None:
            return None

        # - breaks the pint unit parsing mechanism with error TypeError: unsupported operand type(s) for -
        return normalized_name.replace("-", "")

    @staticmethod
    def normalize_unit(unit_expression: str) -> str | None:
        unit_expression = Normalizer.normalize_value(unit_expression)
        if unit_expression is None:
            return None

        if unit_expression in Normalizer.unit_transformations:
            return Normalizer.unit_transformations[unit_expression]

        if unit_expression in Normalizer.blacklisted_factors:
            return None

        unit_expression = re.sub(r'([\d,.])\s(\d)', r'\1\2', unit_expression)  # remove spaces between numbers
        unit_expression = re.sub(r'(?<![a-zA-Z·])x', r'*', unit_expression)  # replace x -> *

        # workaround: setting locale does not work for some reason, unable to set this in pandas because numbers are returned as text
        unit_expression = re.sub(r'(\d+),(\d+)', r'\1.\2',
                                 unit_expression)

        return (unit_expression
                .replace("×", "*")
                .replace("·x", "*")
                .replace("(approx)", "")
                .replace("·", "*")
                .replace("‧", ".")
                .replace("Ω", "Ω")
                .replace("º", "°")
                .replace("m3", "m^3")
                .replace("m2", "m^2")
                .replace("10-", "10^-")
                .replace("10⁻8", "10^-8")
                )
