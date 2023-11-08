import pytest
from inflection import camelize

from constants import *
from lib.category import Category
from lib.conversion_factor import ConversionFactor
from lib.state import State


@pytest.mark.parametrize(
    "text_input",
    [
        "",
        None,
        "nan",
        " ",
    ])
def test_parse_given_empty_common_code_raises_value_error(text_input):
    with pytest.raises(ValueError):
        Unit.parse(STATE, text_input, NAME, DESCRIPTION, CATEGORY, SYMBOL, CONVERSION_FACTOR)


def test_parse_does_normalize_symbol():
    assert Unit.parse(STATE, COMMON_CODE, NAME, DESCRIPTION, CATEGORY, " mg ", CONVERSION_FACTOR).symbol == "mg"


def test_parse_given_unit_creates_expected_unit():
    unit = Unit.parse(STATE, COMMON_CODE, NAME, DESCRIPTION, CATEGORY, SYMBOL, CONVERSION_FACTOR)
    assert unit == Unit(State.DEPRECATED, "TTT", "Test name", "Test description",
                        Category.LEVEL_1_NORMATIVE | Category.LEVEL_1_NORMATIVE_COMMON, "mg", "milligram",
                        ConversionFactor(1e-3, "gram"))


@pytest.mark.parametrize(
    "unit1,unit2,equals",
    [
        (UNIT, Unit.parse(STATE, COMMON_CODE, NAME, DESCRIPTION, CATEGORY, SYMBOL, CONVERSION_FACTOR), True),
        (UNIT, Unit.parse("X", COMMON_CODE, NAME, DESCRIPTION, CATEGORY, SYMBOL, CONVERSION_FACTOR), False),
        (UNIT, Unit.parse(STATE, "TT2", NAME, DESCRIPTION, CATEGORY, SYMBOL, CONVERSION_FACTOR), False),
        (UNIT, Unit.parse(STATE, COMMON_CODE, "Test name 2", DESCRIPTION, CATEGORY, SYMBOL, CONVERSION_FACTOR), False),
        (UNIT, Unit.parse(STATE, COMMON_CODE, NAME, "Test description 2", CATEGORY, SYMBOL, CONVERSION_FACTOR), False),
        (UNIT, Unit.parse(STATE, COMMON_CODE, NAME, DESCRIPTION, "1S", SYMBOL, CONVERSION_FACTOR), False),
        (UNIT, Unit.parse(STATE, COMMON_CODE, NAME, DESCRIPTION, CATEGORY, "g", CONVERSION_FACTOR), False),
        (UNIT, Unit.parse(STATE, COMMON_CODE, NAME, DESCRIPTION, CATEGORY, SYMBOL, "1e-2 g"), False),
    ])
def test_eq_does_equals_same_object(unit1: Unit, unit2: Unit, equals: bool):
    assert (unit1 == unit2) is equals


def test_to_dict_contains_all_public_properties():
    obj = ConversionFactor(1, None)
    properties = [camelize(a, False) for a in dir(obj) if not a.startswith('__') and not callable(getattr(obj, a))]

    assert all([a in ConversionFactor(1, None).to_dict() for a in properties])


@pytest.mark.parametrize(
    "text_input,expected_parsed_symbol",
    [
        ("", None),
        (None, None),
        ("nan", None),
        (" ", None),
        ("m3", "meter ** 3"),
        ("m²", "meter ** 2"),
        ("m", "meter"),
        ("m/s", "meter / second"),

        # catched exceptions below:
        ("nothing", None),
        ("dtex (g/10km)", None),
        ("()", None),
        ("ton.sh-force", None),
    ])
def test_parse_unit_reference_does_parse_symbol_properly(text_input: str | None, expected_parsed_symbol: str | None):
    unit = Unit.parse(STATE, COMMON_CODE, NAME, DESCRIPTION, CATEGORY, text_input, CONVERSION_FACTOR)
    assert unit.parsed_symbol == expected_parsed_symbol
