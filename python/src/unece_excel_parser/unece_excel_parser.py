import argparse
import json
import os

import pandas as pd

from lib.constants import PANDAS_STR_NA_VALUES_CUSTOMIZED
from lib.unit import Unit
from lib.units_analyzer import UnitsAnalyzer

STATUS = "Status"
NAME = "Name"
DESCRIPTION = "Description"
COMMON_CODE = "Common\nCode"
CODE = "Code"
LEVEL_CATEGORY = "Level /_x000D_\nCategory"
SYMBOL = "Symbol"
CONVERSION_FACTOR = "Conversion Factor"


def read_rec20(path: str) -> [Unit]:
    units_rec20 = []
    analyzer = UnitsAnalyzer()

    df = pd.read_excel(path, sheet_name="Annex II & Annex III", na_values=PANDAS_STR_NA_VALUES_CUSTOMIZED,
                       keep_default_na=False)
    for (index, row) in df.iterrows():
        unit = Unit.parse(row[STATUS], row[COMMON_CODE], row[NAME], row[DESCRIPTION],
                          row[LEVEL_CATEGORY], row[SYMBOL], str(row[CONVERSION_FACTOR]))
        units_rec20.append(unit)

        analyzer.add_unit(unit)

    analyzer.link_conversion_factors(units_rec20)
    analyzer.print_summary()

    return units_rec20


def read_rec21(path: str) -> [Unit]:
    units_rec21 = []

    df = pd.read_excel(path, sheet_name="Annex V and VI", na_values=PANDAS_STR_NA_VALUES_CUSTOMIZED,
                       keep_default_na=False, skiprows=2)
    for (index, row) in df.iterrows():
        unit = Unit.parse(row[STATUS], "X" + str(row[CODE]), row[NAME], row[DESCRIPTION], None, None, None)
        units_rec21.append(unit)

    return units_rec21


def run_unece_excel_parser(rec20: str, rec21: str, output: str) -> bool:
    if not os.path.exists(rec20):
        print(f"The file does not exists on path '{rec20}'.")
        return False

    if rec21 is not None and not os.path.exists(rec21):
        print(f"The file does not exists on path '{rec21}'.")
        return False

    print(f"Reading rec 20 file '{rec20}'")
    units = read_rec20(rec20)

    if rec21 is not None:
        print(f"Reading rec. 21 file '{rec21}'")
        units.extend(read_rec21(rec21))

    with open(output, "w") as json_file:
        json.dump([unit.to_dict() for unit in units], json_file, indent=2)

    return True


if __name__ == '__main__':
    parser: argparse.ArgumentParser = argparse.ArgumentParser()
    parser.add_argument('-rec20', dest='rec20', required=True,
                        help="path to the xlsx file with Codes for Units of Measure Used in International Trade (rec. 20)")
    parser.add_argument('-rec21', dest='rec21', required=False,
                        help="path to the xlsx file with Codes for Passengers, Types of Cargo, Packages and Packaging Materials (with Complementary Codes for Package Names) (rec. 21)")
    parser.add_argument('-o', dest='output', required=False, help="path to the output file",
                        default="parsedUneceUnits.json")
    args: argparse.Namespace = parser.parse_args()

    if not run_unece_excel_parser(args.rec20, args.rec21, args.output):
        exit(1)
