# Unece Generator
This project generates the C# unit structures for the UNECE units nuget package.

## Run from cmdline (re-generate)
Run only if JSON file with units was changed to re-generate the structures.

Use pre-defined Rider configuration or execute command:
`./UneceGenerator --file ../../../../../../python/src/unece_excel_parser/parsedUneceUnits.json --output-folder ../../../../UneceUnits/Generated --delete-output-folder-content`