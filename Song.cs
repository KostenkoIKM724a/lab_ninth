namespace Lab09Linq;

// Song model for variant 9 (Music).
public sealed class Song
{
    public string Title { get; init; } = string.Empty;
    public string Artist { get; init; } = string.Empty;
    public string Genre { get; init; } = string.Empty;
    public int DurationSeconds { get; init; }
    public int ReleaseYear { get; init; }
}
