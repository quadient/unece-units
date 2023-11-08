from enum import Flag, auto
from typing import Optional


# src: https://unece.org/sites/default/files/2023-10/Rec20_Rev6e_2009.pdf
class Category(Flag):
    LEVEL_1_NORMATIVE = auto()
    LEVEL_1_NORMATIVE_STANDARD = auto()
    LEVEL_1_NORMATIVE_COMMON = auto()
    LEVEL_2_NORMATIVE_EQUIVALENT = auto()
    LEVEL_3_INFORMATIVE = auto()

    @staticmethod
    def parse_categories(category: str) -> Optional['Category']:
        if not category:
            return None

        all_categories = Category(0)

        for level in category.split('\n'):
            level = level.replace(',', '.').replace('"', '').strip()

            if level.startswith("1"):
                all_categories |= Category.LEVEL_1_NORMATIVE

                if level.endswith('S'):
                    all_categories |= Category.LEVEL_1_NORMATIVE_STANDARD
                elif level.endswith('M'):
                    all_categories |= Category.LEVEL_1_NORMATIVE_COMMON

            elif level.startswith("2"):
                all_categories |= Category.LEVEL_2_NORMATIVE_EQUIVALENT
            elif level.startswith("3"):
                all_categories |= Category.LEVEL_3_INFORMATIVE

        return None if all_categories == Category(0) else all_categories

    def has_flag(self, flag: 'Category') -> bool:
        return self & flag == flag
