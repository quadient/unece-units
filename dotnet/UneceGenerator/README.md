# UNECE units dotnet tools

This solution consists of two projects:

- [UneceGenerator](UneceGenerator/README.md) which can be used to re-generate the C# classes based on
  the `parsedUneceUnits.json` file created by the
  python [unece_excel_parser](../../python/src/unece_excel_parser/README.md) tool.
- [UneceUnits](UneceUnits/README.md) final output project with generated C# classes which is published as a NuGet
  package.