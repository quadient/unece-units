import re


class Normalizer:
    blacklisted_factors = [
        # TODO[j.semerak]: Define them as pint units?
        "use pair",  # NPR
        "-log10(mol/l)",  # Q30
        "mg KOH/g",  # TAN
        "10^[Power in dBW/10] W",  # DBW
        "10^[(Power in dBm-30)/10] W"  # DBM
    ]

    @staticmethod
    def is_empty(text: any) -> bool:
        return text is None or str(text) == "nan" or str(text) == ""

    @staticmethod
    def normalize_value(value) -> str | None:
        if Normalizer.is_empty(value):
            return None

        return str(value)

    @staticmethod
    def normalize_unit_name(name) -> str | None:
        normalized_name = Normalizer.normalize_value(name)
        if normalized_name is None:
            return None

        # - breaks the pint unit parsing mechanism with error TypeError: unsupported operand type(s) for -
        return normalized_name.replace("-", "")

    @staticmethod
    def normalize_unit(conversion_factor) -> str | None:
        conversion_factor = Normalizer.normalize_value(conversion_factor)
        if conversion_factor is None:
            return ""

        if conversion_factor.strip() in Normalizer.blacklisted_factors:
            return None

        conversion_factor = re.sub(r'(\d)\s(\d)', r'\1\2', conversion_factor)  # remove spaces between numbers
        conversion_factor = re.sub(r'(?<![a-zA-Z·])x', r'*', conversion_factor)  # replace x -> *

        # workaround: setting locale does not work for some reason, unable to set this in pandas because numbers are returned as text
        conversion_factor = re.sub(r'(\d+),(\d+)', r'\1.\2',
                                   conversion_factor)

        return (conversion_factor
                .replace("·x", "*")
                .replace("(approx)", "")
                .replace("·", "*")
                .replace("Ω", "Ω")
                .replace("º", "°")
                .replace("m3", "m^3")
                .replace("m2", "m^2")
                .replace("10-", "10^-")
                # ------------------------------
                .replace("milli-inch", "milliinch")
                )
