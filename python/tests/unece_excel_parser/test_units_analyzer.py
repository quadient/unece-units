import pytest

from constants import *
from lib.units_analyzer import UnitsAnalyzer


def test_add_unit_when_adding_duplicated_common_code_does_throw():
    units_analyzer = UnitsAnalyzer()
    units_analyzer.add_unit(UNIT)

    with pytest.raises(ValueError):
        units_analyzer.add_unit(UNIT)


def test_add_unit_when_adding_duplicated_unit_symbol_does_store_duplicate():
    units_analyzer = UnitsAnalyzer()
    units_analyzer.add_unit(Unit.parse(STATE, COMMON_CODE, NAME, DESCRIPTION, CATEGORY, SYMBOL, CONVERSION_FACTOR))
    units_analyzer.add_unit(Unit.parse(STATE, COMMON_CODE2, NAME, DESCRIPTION, CATEGORY, SYMBOL, CONVERSION_FACTOR))
    units_analyzer.add_unit(Unit.parse(STATE, COMMON_CODE3, NAME, DESCRIPTION, CATEGORY, SYMBOL, CONVERSION_FACTOR))

    assert UNIT.symbol in units_analyzer._duplicated_symbols
    assert len(units_analyzer._duplicated_symbols) == 1
    assert UNIT.symbol in units_analyzer._processed_symbols_info
    assert len(units_analyzer._processed_common_codes) == 3

    assert UNIT.parsed_symbol in units_analyzer._unit_common_codes_by_parsed_symbol
    assert units_analyzer._unit_common_codes_by_parsed_symbol[UNIT.parsed_symbol] == [COMMON_CODE, COMMON_CODE2,
                                                                                      COMMON_CODE3]


def test_add_unit_when_empty_symbol_proper_collections_updated():
    units_analyzer = UnitsAnalyzer()
    units_analyzer.add_unit(Unit.parse(STATE, COMMON_CODE, NAME, DESCRIPTION, CATEGORY, None, CONVERSION_FACTOR))

    assert len(units_analyzer._duplicated_symbols) == 0
    assert len(units_analyzer._processed_symbols_info) == 0
    assert len(units_analyzer._unit_common_codes_by_parsed_symbol) == 0

    assert COMMON_CODE in units_analyzer._processed_common_codes
    assert len(units_analyzer._processed_common_codes) == 1


def test_add_unit_when_no_duplicated_unit_duplicated_symbols_are_empty():
    units_analyzer = UnitsAnalyzer()
    units_analyzer.add_unit(UNIT)
    units_analyzer.add_unit(UNIT2)
    units_analyzer.add_unit(UNIT3)

    assert len(units_analyzer._duplicated_symbols) == 0
    assert UNIT.symbol in units_analyzer._processed_symbols_info
    assert UNIT.parsed_symbol in units_analyzer._unit_common_codes_by_parsed_symbol

    assert UNIT2.symbol in units_analyzer._processed_symbols_info
    assert UNIT2.parsed_symbol in units_analyzer._unit_common_codes_by_parsed_symbol

    assert UNIT3.symbol in units_analyzer._processed_symbols_info
    assert UNIT3.parsed_symbol in units_analyzer._unit_common_codes_by_parsed_symbol

    assert len(units_analyzer._processed_common_codes) == 3


def test_link_conversion_factors_given_linked_symbols_does_link_properly():
    units_analyzer = UnitsAnalyzer()
    units_analyzer.add_unit(UNIT)
    units_analyzer.add_unit(UNIT2)
    units_analyzer.add_unit(UNIT3)

    units_analyzer.link_conversion_factors([UNIT, UNIT2, UNIT3])

    assert UNIT.conversion_factor.common_code_references == [COMMON_CODE3]
    assert UNIT2.conversion_factor.common_code_references == [COMMON_CODE3]
    assert UNIT3.conversion_factor.common_code_references == []
    assert units_analyzer._referenced_unit_common_codes == {COMMON_CODE3}


@pytest.mark.parametrize(
    "conversion_factor,expected",
    [
        (None, None),
        ("", None),
        ("nan", None),
        ("1", "dimensionless"),
    ])
def test_link_conversion_factors_given_unit_without_conversion_factor_does_nothing(
        conversion_factor: str | None, expected: str | None):
    units_analyzer = UnitsAnalyzer()
    unit = Unit.parse(STATE, COMMON_CODE, NAME, DESCRIPTION, CATEGORY, SYMBOL, conversion_factor)
    units_analyzer.add_unit(unit)
    units_analyzer.add_unit(
        Unit.parse(STATE, COMMON_CODE2, NAME, DESCRIPTION, CATEGORY, "", "1"))

    units_analyzer.link_conversion_factors([UNIT])

    if expected is None:
        assert unit.conversion_factor is None
    else:
        assert unit.conversion_factor.parsed_symbol == expected


def test_link_conversion_factors_when_target_not_found_is_added_to_unlinked():
    units_analyzer = UnitsAnalyzer()
    common_code = "XXX"
    units = [UNIT, UNIT2, UNIT3, Unit.parse(STATE, common_code, NAME, DESCRIPTION, CATEGORY, "km^3", "1e3 m^3")]
    for unit in units:
        units_analyzer.add_unit(unit)

    units_analyzer.link_conversion_factors(units)

    assert len(units_analyzer._unlinked_parsed_symbols_info) == 1
    assert units_analyzer._unlinked_parsed_symbols_info[0].common_code == common_code
