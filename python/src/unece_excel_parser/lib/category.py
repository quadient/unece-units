from enum import Flag, auto
from typing import Optional


# TODO[j.semerak]: Tests:
# 3.9
# 3.3
# 3.4
# 1M
# 1S
# 3.1
# 1
# 3.8
# 3.5
# 2
# 3,9
# 3.7
# 3.6
# 2S
# 3.2
# 2
# "1S
# 3.5"
# "3.2
# 3.8"
# "2
# 3.9"
# "1M
# 3.5"
# "3.1
# 3.4"
# 1
# 3
# 3,1
# 3,2
# 0

# src: https://unece.org/sites/default/files/2023-10/Rec20_Rev6e_2009.pdf
class Category(Flag):
    LEVEL_1_NORMATIVE = auto()
    LEVEL_1_NORMATIVE_STANDARD = auto()
    LEVEL_1_NORMATIVE_COMMON = auto()
    LEVEL_2_NORMATIVE_EQUIVALENT = auto()
    LEVEL_3_INFORMATIVE = auto()

    @staticmethod
    def parse_categories(input_string) -> Optional['Category']:
        if not input_string:
            return None

        all_categories = Category(0)

        for level in input_string.split('\n'):
            level = level.replace(',', '.').replace('"', '').strip()

            if level.startswith("1"):
                all_categories |= Category.LEVEL_1_NORMATIVE

                if level.endswith('S'):
                    all_categories |= Category.LEVEL_1_NORMATIVE_STANDARD
                elif level.endswith('M'):
                    all_categories |= Category.LEVEL_1_NORMATIVE_COMMON

            elif level.startswith("2"):
                all_categories |= Category.LEVEL_2_NORMATIVE_EQUIVALENT
            else:
                all_categories |= Category.LEVEL_3_INFORMATIVE

        return all_categories

    def has_flag(self, flag):
        return self & flag == flag
