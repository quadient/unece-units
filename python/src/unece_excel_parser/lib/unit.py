import pint
from pint import errors

from lib.category import Category
from lib.conversion_factor import ConversionFactor
from lib.normalizer import Normalizer
from lib.pint_registry import PintRegistryManager
from lib.state import State


class Unit:
    def __init__(self, state: State, common_code: str, name: str, description: str, categories: Category, symbol: str,
                 parsed_symbol: str, conversion_factor: ConversionFactor):
        self.state = state
        self.commonCode = common_code
        self.name = name
        self.description = description
        self.categories = categories
        self.symbol = symbol
        self.parsedSymbol = parsed_symbol
        self.conversionFactor = conversion_factor

    def to_dict(self):
        return {
            "state": self.state.name,
            "commonCode": self.commonCode,
            "name": self.name,
            "description": self.description,
            "symbol": self.symbol,
            "conversionFactor": self.conversionFactor.to_dict() if self.conversionFactor is not None else None,
            "parsedSymbol": self.parsedSymbol,
            "categories": self.categories.name if self.categories is not None else None,
        }

    @staticmethod
    def parse(state, common_code, name, description, category, symbol, conversion_factor) -> 'Unit':
        if Normalizer.is_empty(common_code):
            raise ValueError(f"Invalid common code '{common_code}'.")

        symbol = Normalizer.normalize_unit_name(symbol)

        return Unit(Unit.__parse_state(state), Normalizer.normalize_value(common_code),
                    Normalizer.normalize_unit_name(name),
                    Normalizer.normalize_value(description),
                    Category.parse_categories(Normalizer.normalize_value(category)),
                    symbol, Unit.__parse_unit_reference(symbol),
                    ConversionFactor.parse(conversion_factor))

    @staticmethod
    def __parse_state(state_string: str) -> State:
        state_string = Normalizer.normalize_value(state_string)

        if state_string is None or not isinstance(state_string, str):
            return State.NOT_DEFINED

        state_string = state_string.strip()  # Removing leading/trailing whitespace

        if len(state_string) == 0:
            return State.NOT_DEFINED
        elif len(state_string) != 1:
            raise ValueError(f"Invalid input: Only one character allowed in a state value but received: {state_string}")

        for state in State:
            if state_string == state.value:
                return state

        raise ValueError(f"Invalid state {state_string}.")

    @staticmethod
    def __parse_unit_reference(symbol: str) -> str | None:
        if symbol is None:
            return None

        symbol = Normalizer.normalize_unit(symbol)
        try:
            return str(PintRegistryManager().get_registry().parse_units(symbol))
        except (errors.UndefinedUnitError, ZeroDivisionError, ValueError, AssertionError) as _:
            # print(f"Failed to parse unit name \"{name}\" and \"{symbol}\". Falling back to symbol.")
            return None
