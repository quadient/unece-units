import filecmp
import os

import pytest

from unece_excel_parser import run_unece_excel_parser

current_directory = os.path.dirname(__file__)
base_path = [current_directory, "..", "..", "src", "unece_excel_parser", "files"]
rec20 = os.path.abspath(os.path.join(*base_path, "rec20_Rev17e-2021.xlsx"))
rec21 = os.path.abspath(os.path.join(*base_path, "rec21_Rev12e_Annex-V-VI_2021.xls"))


def test_unece_excel_parser_json_changes_commited():
    output_default_path = os.path.abspath(
        os.path.join(current_directory, "..", "..", "src", "unece_excel_parser", "parsedUneceUnits.json"))

    run_unece_excel_parser(rec20, rec21, "parsedUneceUnitsCreated.json")

    are_equal = filecmp.cmp(output_default_path, "parsedUneceUnitsCreated.json")
    os.remove("parsedUneceUnitsCreated.json")

    # Possible improvement: print diff between files.
    assert are_equal, "The generate JSON file is not equal to the one committed in the repository."


@pytest.mark.parametrize(
    "rec20_path,rec21_path,expected",
    [
        (rec20, rec21, True),
        (rec20, None, True),
        (rec20, "invalid", False),
        ("invalid", rec21, False),
        ("invalid", "invalid", False),
    ])
def test_unece_excel_parser_given_paths_return_proper_result(rec20_path, rec21_path, expected):
    created = run_unece_excel_parser(rec20_path, rec21_path, "parsedUneceUnitsCreated.json")

    if created:
        os.remove("parsedUneceUnitsCreated.json")

    assert created == expected
