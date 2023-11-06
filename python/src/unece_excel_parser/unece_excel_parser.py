import argparse
import json
import os

import pandas as pd

from lib.constants import PANDAS_STR_NA_VALUES_CUSTOMIZED
from lib.unit import Unit
from lib.units_analyzer import UnitsAnalyzer


def read_rec20(path: str):
    units_rec20 = []
    analyzer = UnitsAnalyzer()

    df = pd.read_excel(path, sheet_name='Annex II & Annex III', na_values=PANDAS_STR_NA_VALUES_CUSTOMIZED,
                       keep_default_na=False)
    for (index, row) in df.iterrows():
        unit = Unit.parse(row.iloc[0], row.iloc[1], row.iloc[2], row.iloc[3], row.iloc[4], row.iloc[5],
                          str(row.iloc[6]))
        units_rec20.append(unit)

        analyzer.add_unit(unit)

    analyzer.link_conversion_factors(units_rec20)
    analyzer.print_summary()

    return units_rec20


def read_rec21(path: str):
    units_rec21 = []

    df = pd.read_excel(path, sheet_name='Annex V and VI', na_values=PANDAS_STR_NA_VALUES_CUSTOMIZED,
                       keep_default_na=False, skiprows=2)
    for (index, row) in df.iterrows():
        unit = Unit.parse(row.iloc[0], "X" + str(row.iloc[1]), row.iloc[2], row.iloc[3], None, None, None)
        units_rec21.append(unit)

    return units_rec21


def run():
    '''
    Arguments:
        -rec20: path to the xlsx file with Codes for Units of Measure Used in International Trade (rec. 20)
        -rec21: path to the xlsx file with Codes for Passengers, Types of Cargo, Packages and Packaging Materials (with Complementary Codes for Package Names) (rec. 21)
    '''
    parser: argparse.ArgumentParser = argparse.ArgumentParser()
    parser.add_argument('-rec20', dest='rec20', required=True)
    parser.add_argument('-rec21', dest='rec21', required=False)
    args: argparse.Namespace = parser.parse_args()

    if not os.path.exists(args.rec20):
        print(f"The file does not exists on path '{args.rec20}'.")
        exit(1)

    if args.rec21 is not None and not os.path.exists(args.rec21):
        print(f"The file does not exists on path '{args.rec21}'.")
        exit(1)

    print(f"Reading rec 20 file '{args.rec20}'")
    units = read_rec20(args.rec20)

    if args.rec21 is not None:
        print(f"Reading rec. 21 file '{args.rec21}'")
        units.extend(read_rec21(args.rec21))

    with open("out.json", "w") as json_file:
        json.dump([unit.to_dict() for unit in units], json_file, indent=4)


if __name__ == '__main__':
    run()
