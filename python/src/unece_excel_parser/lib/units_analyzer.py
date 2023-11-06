from lib.unit import Unit


class UnitsAnalyzer:
    def __init__(self):
        self.symbols_by_common_code: {str: str} = {}
        self.unit_common_codes_by_parsed_symbol: {str: [str]} = {}
        self.duplicated_symbols: [str] = []
        self.unlinked_conversion_factors: [[str, str]] = []
        self.referenced_unit_common_codes: set[str] = set()

    def add_unit(self, unit: Unit):
        if unit.symbol is not None:
            if unit.symbol in self.symbols_by_common_code:
                self.duplicated_symbols.append(unit.symbol)

            self.symbols_by_common_code.setdefault(unit.symbol, []).append([unit.commonCode, unit.parsedSymbol])

        if unit.parsedSymbol is not None:
            self.unit_common_codes_by_parsed_symbol.setdefault(unit.parsedSymbol, []).append(unit.commonCode)

    def link_conversion_factors(self, units: [Unit]):
        for unit in units:
            if unit.conversionFactor is not None and unit.conversionFactor.parsedSymbol is not None:
                if unit.conversionFactor.parsedSymbol in self.unit_common_codes_by_parsed_symbol:
                    unit.conversionFactor.set_references(unit.commonCode,
                                                         self.unit_common_codes_by_parsed_symbol[
                                                             unit.conversionFactor.parsedSymbol])

                    if unit.conversionFactor.commonCodeReferences is not None:
                        for commonCode in unit.conversionFactor.commonCodeReferences:
                            self.referenced_unit_common_codes.add(commonCode)
                else:
                    self.unlinked_conversion_factors.append([unit.commonCode, unit.conversionFactor.parsedSymbol])

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
