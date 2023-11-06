from typing import Optional

from pint import errors

from lib.constants import DIMENSIONLESS
from lib.normalizer import Normalizer
from lib.pint_registry import PintRegistryManager


class ConversionFactor:
    def __init__(self, factor: float | None, unit_reference_parsed_symbol: str | None):
        self.factor = factor
        self.parsed_symbol = unit_reference_parsed_symbol
        self.common_code_references: [str] = []

    def __eq__(self, other):
        if isinstance(other, ConversionFactor):
            return self.factor == other.factor and self.parsed_symbol == other.parsed_symbol and self.common_code_references == other.common_code_references
        return False

    def set_references(self, source_common_code: str, unit_common_code_target_references: [str]):
        self.common_code_references = [x for x in unit_common_code_target_references if
                                       x != source_common_code]

    def to_dict(self):
        return {
            "factor": self.factor,
            "parsedSymbol": self.parsed_symbol,
            "commonCodeReferences": self.common_code_references if self.common_code_references else None,
        }

    def __repr__(self):
        return str(self.to_dict())

    @staticmethod
    def parse(conversion_factor: str) -> Optional['ConversionFactor']:
        conversion_factor = Normalizer.normalize_unit(conversion_factor)

        if conversion_factor is None:
            return None

        try:
            parsed = PintRegistryManager().get_registry().parse_expression(conversion_factor)

            if isinstance(parsed, (int, float)):
                return ConversionFactor(parsed, DIMENSIONLESS)

            # Note: possibly check incompatibility of conversion using pint here?

        except errors.OffsetUnitCalculusError as _:
            print(f"Unable to parse offset unit {conversion_factor}. Unit will be not convertible.")
            return None

        return ConversionFactor(parsed.magnitude, str(parsed.units))
