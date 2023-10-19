from enum import Enum


# src: https://unece.org/sites/default/files/2023-10/Rec20_Rev6e_2009.pdf
class State(Enum):
    NOT_DEFINED = None
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
