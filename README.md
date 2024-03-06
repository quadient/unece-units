# unece-units

Units library supporting UNECE rec. 20 and rec. 21 standards

# Content

This repository contains two main tools:

* python UNECE Excel parser that parses input XLXS file into pre-processed JSON output. See
  unece_excel_parser's [README](python/src/unece_excel_parser/README.md).
* UNECE units dotnet tools that uses pre-processed JSON to create c# classes for working with UNECE units that are
  packed into a NuGet package.

# References

UNECE standards are located on https://unece.org/trade/uncefact/cl-recommendations. Basic description of the UNECE
standard is located on https://unece.org/sites/default/files/2023-10/Rec20_Rev6e_2009.pdf.

Also the Excel files and the PDF explaining the data in the standard are located in the `python/src/files` folder.