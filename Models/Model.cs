public class VideoGame
{
    public string Title { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }
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