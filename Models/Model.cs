public class VideoGame
{
    public string Title { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }

    public VideoGame(string title, int year, string genre)
    {
        Title = title;
        Year = year;
        Genre = genre;
    }

    public override string ToString()
    {
        return $"Title: {Title}. Release year: {Year}. Genre: {Genre}";
    }
}

public class Model
{
    public List<VideoGame> VideoGames { get; set; }
    public Model ()
    {
        VideoGames = new List<VideoGame>
        {
            // Add games here
        };
    }
}