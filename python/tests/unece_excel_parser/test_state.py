import pytest

from lib.state import State


@pytest.mark.parametrize(
    "text_input,expected",
    [
        (None, State.ACTIVE),
        ("", State.ACTIVE),
        (" ", State.ACTIVE),
        ("+", State.ADDED),
        ("#", State.CHANGED_NAME),
        ("¦", State.CHANGED_CHARACTERISTICS),
        ("D", State.DEPRECATED),
        ("X", State.MARKED_AS_DELETED),
        ("=", State.REINSTATED),
    ]
)
def test_parse_given_valid_state_returns_enum_value(text_input: str | None, expected):
    assert State.parse(text_input) == expected


def test_parse_all_enum_values_are_supported():
    for state in State:
        assert State.parse(state.value) == state


@pytest.mark.parametrize(
    "text_input",
    [
        "invalid",
        "F",
        "ACTIVE",
    ]
)
def test_parse_given_invalid_input_does_raise_value_error(text_input):
    with pytest.raises(ValueError):
        State.parse(text_input)
