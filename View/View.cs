public class View
{
    public void DisplayGames(List<VideoGame> VideoGames)
    {
        foreach (var VideoGame in VideoGames)
        {
            Console.WriteLine(VideoGame);
        }
    }
}