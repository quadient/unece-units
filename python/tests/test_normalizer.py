from lib.normalizer import Normalizer
import pytest

@pytest.mark.parametrize(
    "text_input,expected",
    [("", True), ("nan", True), (None, True), (" ", True), ("a", False), ("1", False)],
)
def test_is_empty_given_empty_value_returns_true(text_input: str | None, expected: bool):
    assert Normalizer.is_empty(text_input) is expected
