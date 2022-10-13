using SixLabors.ImageSharp;

namespace MazeGeneration;

public interface IMazeGenerator
{
    Task GenerateMaze();
    Image GetGraphicalMazeAsync(bool includeHeatMap = false);
    string GetTextMazeAsync(bool includePath = false);
}