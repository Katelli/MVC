public class Controller
{
    private Model _model;
    private View _view;

    public Controller(Model model, View view)
    {
        _model = model;
        _view = view;
    }

    public void Run()
    {

    }
    //          Todo list
    // Add Game
    private void AddGame()
    {
        Console.WriteLine("Enter the game's title/name");
        string? title = Console.ReadLine();

        while(string.IsNullOrEmpty(title))
        {
            Console.WriteLine("Title can not be empty");
            title = Console.ReadLine();
        }


        Console.WriteLine("Enter the game's release year");

        string? yearInput = Console.ReadLine();
        int year;
        while(!int.TryParse(yearInput, out year))
        {
            Console.WriteLine("There was an error with the data submitted, please input the year using numbers");
            yearInput = Console.ReadLine();
        }


        Console.WriteLine("Enter the game's genre");
        string? genre = Console.ReadLine();
        while(string.IsNullOrEmpty(genre))
        {
            Console.WriteLine("Genre can not be empty");
            genre = Console.ReadLine();
        }

    }

    // Remove Game

    // Update Title, Year or Genre

}
