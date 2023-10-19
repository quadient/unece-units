from lib.category import Category
from lib.state import State


class UnitsAnalyzer:
    def __init__(self):
        self.symbols_by_common_code = {}
        self.units_by_parsed_symbol = {}
        self.duplicated_symbols = []
        self.unlinked_conversion_factors = []
        self.referenced_unit_common_codes = set()

    def add_unit(self, unit):
        if unit.symbol is not None:
            if unit.symbol in self.symbols_by_common_code:
                self.duplicated_symbols.append(unit.symbol)

            self.symbols_by_common_code.setdefault(unit.symbol, []).append([unit.commonCode, unit.parsedSymbol])

        if unit.parsedSymbol is not None:
            self.units_by_parsed_symbol.setdefault(unit.parsedSymbol, []).append(unit)

    def link_conversion_factors(self, units):
        for unit in units:
            if unit.conversionFactor is not None and unit.conversionFactor.parsedSymbol is not None:
                if unit.conversionFactor.parsedSymbol in self.units_by_parsed_symbol:
                    unit.conversionFactor.set_reference(
                        self.find_unit_reference(self.units_by_parsed_symbol[unit.conversionFactor.parsedSymbol]))

                    if unit.conversionFactor.commonCodeReference is not None:
                        self.referenced_unit_common_codes.add(unit.conversionFactor.commonCodeReference)
                else:
                    self.unlinked_conversion_factors.append([unit.commonCode, unit.conversionFactor.parsedSymbol])

    # An effort to try to prioritize LEVEL 1 Normative units over other units. Ideally there should be no duplicates.
    # TODO[j.semerak]: Improve
    @staticmethod
    def find_unit_reference(units_with_same_symbol: []):
        reference = None

        if len(units_with_same_symbol) == 1:
            return units_with_same_symbol[0].commonCode

        # duplicates only below
        for unitWithSameSymbol in units_with_same_symbol:
            if unitWithSameSymbol.state == State.DEPRECATED or unitWithSameSymbol.state == State.MARKED_AS_DELETED:
                continue

            if unitWithSameSymbol.categories.has_flag(
                    Category.LEVEL_1_NORMATIVE) and not unitWithSameSymbol.categories.has_flag(
                Category.LEVEL_1_NORMATIVE_COMMON):
                return unitWithSameSymbol.commonCode

            reference = unitWithSameSymbol.commonCode

        if reference is None:
            print(
                f"WARNING! All unit references are DEPRECATED or MARKED_AS_DELETED for {units_with_same_symbol}. Selecting first of them {units_with_same_symbol[0].commonCode}.")
            reference = units_with_same_symbol[0].commonCode

        return reference

    def print_summary(self):
        print(f"Found {len(self.duplicated_symbols)} duplicated symbols.")
        print(f"Duplicated symbols below are used in an conversion factor and could possibly misbehave:")
        for unitSymbol in self.duplicated_symbols:
            symbol_units = self.symbols_by_common_code[unitSymbol]

            for symbolUnitPair in symbol_units:
                if symbolUnitPair[0] in self.referenced_unit_common_codes:
                    print(
                        f" - Symbol '{unitSymbol}' is used for multiple common codes: {symbol_units}. Unit '{symbolUnitPair}' is referenced by a conversion factor.")

        print(f"Found {len(self.unlinked_conversion_factors)} conversion factors that are missing linked unit target.")

        for conversionFactor in self.unlinked_conversion_factors:
            print(f"Conversion factor for '{conversionFactor[0]}' references unknown unit: '{conversionFactor[1]}'")
