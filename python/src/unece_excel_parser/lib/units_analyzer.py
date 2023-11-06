from collections import namedtuple
from typing import Dict

from lib.constants import DIMENSIONLESS
from lib.unit import Unit

SymbolInfo = namedtuple('SymbolInfo', ['common_code', 'parsed_symbol'])


class UnitsAnalyzer:
    def __init__(self):
        self._processed_symbols_info: Dict[str, list[SymbolInfo]] = {}
        self._unit_common_codes_by_parsed_symbol: Dict[str, list[str]] = {}
        self._duplicated_symbols: [str] = []
        self._unlinked_parsed_symbols_info: list[SymbolInfo] = []
        self._referenced_unit_common_codes: set[str] = set()

    def add_unit(self, unit: Unit):
        if unit.symbol is not None:
            if unit.symbol in self._processed_symbols_info:
                self._duplicated_symbols.append(unit.symbol)

            self._processed_symbols_info.setdefault(unit.symbol, []).append(
                SymbolInfo(unit.common_code, unit.parsed_symbol))

        if unit.parsed_symbol is not None:
            self._unit_common_codes_by_parsed_symbol.setdefault(unit.parsed_symbol, []).append(unit.common_code)

    def link_conversion_factors(self, units: [Unit]):
        for unit in units:
            if unit.conversion_factor is None:
                continue

            if unit.conversion_factor.parsed_symbol is None or unit.conversion_factor.parsed_symbol == DIMENSIONLESS:
                continue

            if unit.conversion_factor.parsed_symbol in self._unit_common_codes_by_parsed_symbol:
                symbol_common_codes = self._unit_common_codes_by_parsed_symbol[unit.conversion_factor.parsed_symbol]
                unit.conversion_factor.set_references(unit.common_code, symbol_common_codes)

                for commonCode in unit.conversion_factor.common_code_references:
                    self._referenced_unit_common_codes.add(commonCode)
            else:
                self._unlinked_parsed_symbols_info.append(
                    SymbolInfo(unit.common_code, unit.conversion_factor.parsed_symbol))

    def print_summary(self):
        print(f"Found {len(self._duplicated_symbols)} duplicated symbols.")
        print(f"Duplicated symbols below are used in an conversion factor and could possibly misbehave:")

        for unit_symbol in self._duplicated_symbols:
            symbol_units = self._processed_symbols_info[unit_symbol]

            for symbol_unit_pair in symbol_units:
                if symbol_unit_pair.common_code in self._referenced_unit_common_codes:
                    print(
                        f" - Symbol '{unit_symbol}' is used for multiple common codes: {symbol_units}")
                    break

        print(f"Unable to link {len(self._unlinked_parsed_symbols_info)} parsed symbols.")

        for symbol_info in self._unlinked_parsed_symbols_info:
            print(
                f"Unit with commonCode '{symbol_info.common_code}' references unknown parsed symbol: '{symbol_info.parsed_symbol}'")
