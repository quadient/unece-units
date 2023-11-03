from typing import Optional

import pint
from pint import errors

from lib.normalizer import Normalizer
from lib.pint_registry import PintRegistryManager


class ConversionFactor:
    def __init__(self, factor: float | None, unit_reference: str | None):
        self.factor = factor
        self.parsedSymbol = unit_reference
        self.commonCodeReference = None

    def set_reference(self, unit_reference: str):
        if self.parsedSymbol == "dimensionless":
            self.commonCodeReference = None
            return

        self.commonCodeReference = unit_reference

    def to_dict(self):
        return {
            "factor": self.factor,
            "parsedSymbol": self.parsedSymbol,
            "commonCodeReference": self.commonCodeReference,
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

            # TODO[j.semerak]: Check incompatibility using pint?
            # if source_unit is not None and not source_unit.is_compatible_with(parsed):
            #     print(
            #         f"Warning! Conversion factor {conversion_factor} is not compatible with source unit {source_unit}.")

        except errors.OffsetUnitCalculusError as e:
            print(f"Unable to parse offset unit {conversion_factor}. Unit will be not convertible.")
            return None

        return ConversionFactor(parsed.magnitude, str(parsed.units))
