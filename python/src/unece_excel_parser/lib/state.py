from enum import Enum

from lib.normalizer import Normalizer


# src: https://unece.org/sites/default/files/2023-10/Rec20_Rev6e_2009.pdf
class State(Enum):
    ACTIVE = None
    # Added. New unit added in this release of the code list
    ADDED = '+'
    # Changed name. Changes to the unit name in this release of the code list
    CHANGED_NAME = '#'
    # Changed characteristic(s). Changes other than to the unit name in this release of the code list, e.g. a change
    # to the level/category
    CHANGED_CHARACTERISTICS = '¦'
    # Deprecated. Units not recommended for use by the Bureau
    DEPRECATED = 'D'
    # Marked as deleted. Units marked as deleted will be retained indefinitely in the code lists. When appropriate,
    # these units may subsequently be reinstated via the maintenance process
    MARKED_AS_DELETED = 'X'
    # Reinstated. Units previously marked as deleted and reinstated
    REINSTATED = '='

    @staticmethod
    def parse(state_string: str | None) -> 'State':
        state_string = Normalizer.normalize_value(state_string)

        if state_string is None:
            return State.ACTIVE
        elif len(state_string) != 1:
            raise ValueError(f"Invalid input: Only one character allowed in a state value but received: {state_string}")

        if state_string in states_dictionary:
            return states_dictionary[state_string]

        raise ValueError(f"Invalid state {state_string}.")


states_dictionary = dict([(State.ADDED.value, State.ADDED), (State.CHANGED_NAME.value, State.CHANGED_NAME),
                          (State.CHANGED_CHARACTERISTICS.value, State.CHANGED_CHARACTERISTICS),
                          (State.DEPRECATED.value, State.DEPRECATED),
                          (State.MARKED_AS_DELETED.value, State.MARKED_AS_DELETED),
                          (State.REINSTATED.value, State.REINSTATED)])
