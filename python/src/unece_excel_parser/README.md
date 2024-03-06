# UNECE units python pre-processing tool

Python based UNECE Excel Parser that parses input UNECE XLXS file into pre-processed JSON output.

This JSON can then used as input to re-generate dotnet UNECE units classes in
the [dotnet UneceGenerator](../../../dotnet/UneceGenerator/README.md).

# Development

- developed using python `3.12.0`
- mainly using `pint` library for linking units
- in the project root folder:
    - `cd python`
    - create virtual environment `python -m venv venv`
    - activate virtual environment, for example on windows run `.\venv\Scripts\Activate.ps1`
    - run `pip install -e src/unece_excel_parser` to install dependencies & fix imports
    - run `pip install -e src/unece_excel_parser[dev]` to install dev dependencies (for running tests)
    - (optional) set python interpreter in dev IDE to point to python.exe in venv folder

## Run

From `python/src/unece_excel_parser` folder run:

`python .\unece_excel_parser.py -rec20 files/rec20_Rev17e-2021.xlsx -rec21 files/rec21_Rev12e_Annex-V-VI_2021.xls`
