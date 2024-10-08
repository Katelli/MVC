public class Controller
{
    private Model model;
    private View view;

    public Controller(Model model, View view)
    {
        this.model = model;
        this.view = view;
    }

    public void Run()
    {

    }
    //          Todo list
    // Add Game
    private void AddGame()
    {
        Console.WriteLine("Enter the game's title");
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
    // Remove game
    private void RemoveGame()
    {
        Console.WriteLine("Please enter the title of the game you wish to remove");
        string? title = Console.ReadLine();

        if (string.IsNullOrEmpty(title))
        {
            Console.WriteLine("Title can not be empty");
            return;
        }

        if(model.RemoveGame(title))
        {
            Console.WriteLine($"Game {title} removed successfully.");
        }
        else
        {
            Console.WriteLine($"Game {title} not found");
        }
    }

    // Update Title, Year or Genre

}
