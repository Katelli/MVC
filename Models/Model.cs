using System.Security.Cryptography.X509Certificates;

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
            new VideoGame("The Planet Crafter", 2024, "Space survival, Terraformation"),
            new VideoGame("Dragon Quest Builders 2", 2018, "Action, Role-playing, Sandbox"),
            new VideoGame("Stardew Valley", 2016, "Farm life sim, Role-playing")
        };
    }

    public bool RemoveGame(string title)
    {
        var gameToRemove = VideoGames.Find(g => g.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if(gameToRemove != null)
        {
            VideoGames.Remove(gameToRemove);
            return true;
        }
        else
        {
            return false;
        }
    }
    
}