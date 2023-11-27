using FluentAssertions;
using UneceGenerator;

namespace UneceUnits.Tests;

public class Integration : IDisposable
{
    private const string OutputDirectory = "out";

    [Fact]
    async Task WhenInputJsonChanged_AllChangesWereCommitted()
    {
        await Generator.Run(new FileInfo("../../../../../../python/src/unece_excel_parser/parsedUneceUnits.json"),
            new DirectoryInfo(OutputDirectory), true);

        var alreadyGeneratedFiles =
            Directory.GetFiles("../../../../UneceUnits/Generated").OrderBy(path => path).ToList();
        var generatedFiles = Directory.GetFiles(OutputDirectory).OrderBy(path => path).ToList();

        alreadyGeneratedFiles.Count.Should().Be(generatedFiles.Count,
            "Changes from the input file must be reflected in the C# classes, run the UneceGenerator.");

        for (var i = 0; i < alreadyGeneratedFiles.Count; i++)
        {
            var file1Content = await File.ReadAllLinesAsync(alreadyGeneratedFiles[i]);
            var file2Content = await File.ReadAllLinesAsync(generatedFiles[i]);

            file1Content.Should().Equal(file2Content,
                $"files {alreadyGeneratedFiles[i]} and {generatedFiles[i]} should be equal");
        }
    }

    public void Dispose()
    {
        if (Directory.Exists(OutputDirectory))
        {
            Directory.Delete(OutputDirectory, true);
        }
    }
}