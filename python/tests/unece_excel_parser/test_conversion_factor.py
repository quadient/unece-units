import pytest

from lib.conversion_factor import ConversionFactor


@pytest.mark.parametrize(
    "text_input",
    [
        "",
        "nan",
        None,
        " ",
    ])
def test_parse_given_empty_value_returns_none(text_input: str | None):
    assert ConversionFactor.parse(text_input) is None


@pytest.mark.parametrize(
    "text_input,expected",
    [
        ("1", ConversionFactor(1, None)),
        ("1.5", ConversionFactor(1.5, None)),
        ("1,5", ConversionFactor(1.5, None)),
        ("10^6", ConversionFactor(1000000, None)),
        ("1m", ConversionFactor(1, "meter")),
        ("rad/s", ConversionFactor(1, "radian / second")),
        ("1m/s", ConversionFactor(1, "meter / second")),
        ("1m/s^2", ConversionFactor(1, "meter / second ** 2")),
        ("7,200 778 x 10⁻⁴ kg x m", ConversionFactor(7.200778e-4, "kilogram * meter")),
        ("7,200 778 x 10⁻⁴ kg · m", ConversionFactor(7.200778e-4, "kilogram * meter")),
        ("7, 200 778 x 10⁻⁴ kg · m", ConversionFactor(7.200778e-4, "kilogram * meter")),
        ("7, 200 778 · 10⁻⁴ kg · m", ConversionFactor(7.200778e-4, "kilogram * meter")),
        ("5, 68261 * 10⁻⁴ m³", ConversionFactor(5.68261e-4, "meter ** 3")),
        ("5. 68261 * 10⁻⁴ m³", ConversionFactor(5.68261e-4, "meter ** 3")),
        ("0.1 Np", None)  # unable to multiply offset units
    ])
def test_parse_given_text_conversion_factor_returns_expected_conversion_factor(text_input: str,
                                                                               expected: ConversionFactor):
    assert ConversionFactor.parse(text_input) == expected


def test_parse_given_offset_unit_conversion_factor_returns_none():
    assert ConversionFactor.parse("0.1 Np") is None


def test_to_dict_does_match_property_names():
    assert ConversionFactor(1, None).to_dict() == {"factor": 1, "parsedSymbol": None, "commonCodeReferences": None}


def test_to_dict_contains_all_public_properties():
    obj = ConversionFactor(1, None)
    properties = [a for a in dir(obj) if not a.startswith('__') and not callable(getattr(obj, a))]
    assert all([a in ConversionFactor(1, None).to_dict() for a in properties])


def test_set_references_does_set_proper_common_code_references_except_itself():
    conversion_factor = ConversionFactor(1, None)
    conversion_factor.set_references("a", ["a", "b", "c"])
    assert conversion_factor.commonCodeReferences == ["b", "c"]


def test_set_references_does_overwrite_all_previous_references():
    conversion_factor = ConversionFactor(1, None)
    conversion_factor.set_references("a", ["a", "b", "c"])
    conversion_factor.set_references("a", ["a", "b"])
    assert conversion_factor.commonCodeReferences == ["b"]


@pytest.mark.parametrize(
    "conversion_factor1,conversion_factor2,equals",
    [
        (ConversionFactor(1, None), ConversionFactor(1, None), True),
        (ConversionFactor(1, None), ConversionFactor(2, None), False),
        (ConversionFactor(1, None), ConversionFactor(1, "meter"), False),
        (ConversionFactor(1, "meter"), ConversionFactor(1, "meter"), True),
        (ConversionFactor(1, "meter"), ConversionFactor(2, "meter"), False),
    ]
)
def test_eq_does_equals_same_object(conversion_factor1: ConversionFactor, conversion_factor2: ConversionFactor,
                                    equals: bool):
    assert (conversion_factor1 == conversion_factor2) is equals
