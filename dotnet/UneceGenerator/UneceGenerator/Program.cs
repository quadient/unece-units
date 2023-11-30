﻿using System.CommandLine;
using UneceGenerator;

var fileOption = new Option<FileInfo>(
    name: "--file",
    description: "Path to the file with the UNECE units JSON.")
{
    IsRequired = true,
};
fileOption.AddAlias("-f");

var outputFolderOption = new Option<DirectoryInfo>(
    name: "--output-folder",
    description: "Path to the output folder.")
{
    IsRequired = false,
};
outputFolderOption.AddAlias("-o");

var deleteFolderContent = new Option<bool>(
    name: "--delete-output-folder-content",
    description: "Delete content of the output folder before generating new files.")
{
    IsRequired = false,
};
deleteFolderContent.AddAlias("-d");

var rootCommand =
    new RootCommand(
        "C# Unit classes generator which generates C# classes from the UNECE JSON file previously generated by python script.")
    {
        fileOption, outputFolderOption, deleteFolderContent
    };

rootCommand.SetHandler(Generator.Run, fileOption, outputFolderOption, deleteFolderContent);
return await rootCommand.InvokeAsync(args);