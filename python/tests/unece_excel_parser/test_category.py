import pytest

from lib.category import Category


@pytest.mark.parametrize(
    "text_input,expected",
    [
        ("", None),
        ("nan", None),
        (None, None),
        (" ", None),
        ("a", None),
        (0, None),
        ("something unexpected?", None),
        ("1M", Category.LEVEL_1_NORMATIVE | Category.LEVEL_1_NORMATIVE_COMMON),
        ("1S", Category.LEVEL_1_NORMATIVE | Category.LEVEL_1_NORMATIVE_STANDARD),
        ("1", Category.LEVEL_1_NORMATIVE),
        ("2", Category.LEVEL_2_NORMATIVE_EQUIVALENT),
        ("2.1", Category.LEVEL_2_NORMATIVE_EQUIVALENT),
        ("2,4", Category.LEVEL_2_NORMATIVE_EQUIVALENT),
        ("3,9", Category.LEVEL_3_INFORMATIVE),
        ("3.7", Category.LEVEL_3_INFORMATIVE),
        ("3", Category.LEVEL_3_INFORMATIVE),
        ("""1S
        2,4
        3,9""",
         Category.LEVEL_1_NORMATIVE | Category.LEVEL_1_NORMATIVE_STANDARD | Category.LEVEL_2_NORMATIVE_EQUIVALENT | Category.LEVEL_3_INFORMATIVE),
        ("""asd
        3,9
        3,4
        dsa
        """,
         Category.LEVEL_3_INFORMATIVE),
        ("""2.1
        3,9
        """,
         Category.LEVEL_2_NORMATIVE_EQUIVALENT | Category.LEVEL_3_INFORMATIVE),
    ]
)
def test_parse_categories_given_categories_does_parse_properly(text_input: str | None, expected: Category):
    assert Category.parse_categories(text_input) is expected


@pytest.mark.parametrize(
    "category,flag,expected",
    [
        (Category(0), Category.LEVEL_1_NORMATIVE, False),
        (Category(0), Category.LEVEL_3_INFORMATIVE, False),
        (Category.LEVEL_1_NORMATIVE, Category.LEVEL_1_NORMATIVE, True),
        (Category.LEVEL_1_NORMATIVE, Category.LEVEL_1_NORMATIVE_STANDARD, False),
        (Category.LEVEL_1_NORMATIVE | Category.LEVEL_1_NORMATIVE_STANDARD, Category.LEVEL_1_NORMATIVE, True),
        (Category.LEVEL_1_NORMATIVE | Category.LEVEL_1_NORMATIVE_STANDARD, Category.LEVEL_1_NORMATIVE_STANDARD, True),
        (Category.LEVEL_3_INFORMATIVE | Category.LEVEL_2_NORMATIVE_EQUIVALENT, Category.LEVEL_1_NORMATIVE_STANDARD,
         False),
        (Category.LEVEL_3_INFORMATIVE | Category.LEVEL_2_NORMATIVE_EQUIVALENT, Category.LEVEL_3_INFORMATIVE, True),
    ])
def test_has_flag_does_detect_flag_properly(category: Category, flag: Category, expected: bool):
    assert category.has_flag(flag) is expected
