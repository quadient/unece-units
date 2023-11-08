import pytest

from lib.normalizer import Normalizer


@pytest.mark.parametrize(
    "text_input,expected",
    [("", True), ("nan", True), (None, True), (" ", True), ("a", False), (0, False), ("1", False)],
)
def test_is_empty_given_empty_value_returns_expected(text_input: str | None, expected: bool):
    assert Normalizer.is_empty(text_input) is expected


def test_normalize_value_returns_trimmed_string():
    normalized = Normalizer.normalize_value(" a test  ")
    assert normalized == "a test"


@pytest.mark.parametrize(
    "text_input",
    ["", "nan", None, " "],
)
def test_normalize_given_empty_value_returns_none(text_input):
    assert Normalizer.normalize_value(text_input) is None


def test_normalize_value_converts_to_string():
    # noinspection PyTypeChecker
    normalized = Normalizer.normalize_value(1)
    assert isinstance(normalized, str)
    assert normalized == "1"


def test_normalize_unit_name_does_replace_minus_sign():
    normalized = Normalizer.normalize_unit_name(" a-test ")
    assert normalized == "atest"


@pytest.mark.parametrize(
    "text_input",
    ["", "nan", None, " "],
)
def test_normalize_unit_given_empty_value_returns_none(text_input):
    assert Normalizer.normalize_unit(text_input) is None


def test_normalize_unit_does_perform_transformations():
    normalized = Normalizer.normalize_unit("'")
    assert normalized == "arcsec"


@pytest.mark.parametrize(
    "text_input",
    ["''", "a'", "'a", "' a", "'\na"],
)
def test_normalize_unit_when_not_exact_match_does_not_perform_transformations(text_input):
    normalized = Normalizer.normalize_unit(text_input)
    assert normalized == text_input


@pytest.mark.parametrize(
    "text_input",
    Normalizer.blacklisted_factors,
)
def test_normalize_unit_given_blacklisted_factor_return_none(text_input):
    assert Normalizer.normalize_unit(text_input) is None


@pytest.mark.parametrize(
    "text_input, expected",
    [
        ("1,157 41 × 10⁻⁵ s⁻¹", "1.15741 * 10⁻⁵ s⁻¹"),
        ("1, 157 41 · 10⁻⁵ s⁻¹ (approx)", "1.15741 * 10⁻⁵ s⁻¹ "),
        ("10⁻⁹ Ω·x m", "10⁻⁹ Ω* m"),
        ("1. 15 741 × 10-5 m3/s", "1.15741 * 10^-5 m^3/s"),
        ("1. 15 741 x 10⁻8 m2/s", "1.15741 * 10^-8 m^2/s"),
        ("kN/m2", "kN/m^2"),
        ("kg x m² x s⁻² x W⁻⁰‧⁵", "kg * m² * s⁻² * W⁻⁰.⁵"),
        ("inH₂O (60 ºF)", "inH₂O (60 °F)"),
        ("dtex", "dtex"),
        ("7,030 696 x 10² kg/m²", "7.030696 * 10² kg/m²"),
        ("4,719 474 x 10⁻⁴ m³/s", "4.719474 * 10⁻⁴ m³/s"),
        ("27,027 x 10⁻¹² Ci/kg", "27.027 * 10⁻¹² Ci/kg"),
        ("1,602 176 487 x 10⁻¹⁹ J x m²/kg", "1.602176487 * 10⁻¹⁹ J * m²/kg"),
    ],
)
def test_normalize_unit_given_input_does_fix_the_syntax(text_input, expected):
    normalized = Normalizer.normalize_unit(text_input)
    assert normalized == expected
