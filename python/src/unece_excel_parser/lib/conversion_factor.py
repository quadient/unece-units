from typing import Optional

from pint import errors

from lib.normalizer import Normalizer
from lib.pint_registry import PintRegistryManager


class ConversionFactor:
    def __init__(self, factor: float | None, unit_reference_parsed_symbol: str | None):
        self.factor = factor
        self.parsedSymbol = unit_reference_parsed_symbol
        self.commonCodeReferences: [str] = []

    def set_references(self, source_common_code: str, unit_common_code_target_references: [str]):
        self.commonCodeReferences = [x for x in unit_common_code_target_references if x != source_common_code]

    def to_dict(self):
        return {
            "factor": self.factor,
            "parsedSymbol": self.parsedSymbol,
            "commonCodeReferences": self.commonCodeReferences if self.commonCodeReferences else None,
        }

    @staticmethod
    def parse(conversion_factor: str) -> Optional['ConversionFactor']:
        conversion_factor = Normalizer.normalize_unit(conversion_factor)

        if conversion_factor == "":
            return None

        try:
            parsed = PintRegistryManager().get_registry().parse_expression(conversion_factor)

            if isinstance(parsed, (int, float)):
                return ConversionFactor(parsed, None)

            # Note: possibly check incompatibility of conversion using pint here?

        except errors.OffsetUnitCalculusError as e:
            print(f"Unable to parse offset unit {conversion_factor}. Unit will be not convertible.")
            return None

        return ConversionFactor(parsed.magnitude, str(parsed.units))
