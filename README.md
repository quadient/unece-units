# unece-units

Units library supporting UNECE rec. 20 and rec. 21 standards

# Development

- developed on python `3.12.0`
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

# References

UNECE standards are located on https://unece.org/trade/uncefact/cl-recommendations. Basic description of the UNECE
standard is located on https://unece.org/sites/default/files/2023-10/Rec20_Rev6e_2009.pdf.

Also the Excel files and the PDF explaining the data in the standard are located in the `python/src/files` folder.