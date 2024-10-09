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
        bool exit = false;

        while(!exit)
        {
            Console.WriteLine("Welcome to my game list");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Write 1 to display the list of games");
            Console.WriteLine("Write 2 to add a new game to the list");
            Console.WriteLine("Write 3 to change the details of a game");
            Console.WriteLine("Write 4 to remove a game");
            Console.WriteLine("Write 5 to exit the program");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    view.DisplayGames(model.GetGames());
                    break;

                case "2":
                    AddGame();
                    break;

                case "3":
                    UpdateGame();
                    break;

                case "4":
                    RemoveGame();
                    break;

                case "5":
                    exit = true;
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again");
                    break;
            }
        }
    }
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

        model.AddGame(title, year, genre);
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
    private void UpdateGame()
    {
        Console.WriteLine("Enter the title of the game to update");
        string? title = Console.ReadLine();

        if (string.IsNullOrEmpty(title))
        {
            Console.WriteLine("title can not be empty");
            return;
        }
        else 
        {
            Console.WriteLine("What do you want to update?");
            Console.WriteLine("Write 1 to update Title");
            Console.WriteLine("Write 2 to update Release Year");
            Console.WriteLine("Write 3 to update Genre");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1": 
                    Console.WriteLine("Enter the new title for the game");

                    string? newTitle = Console.ReadLine();

                    if (string.IsNullOrEmpty(newTitle))
                    {
                        Console.WriteLine("New Title can not be empty");
                        return;
                    }
                    model.UpdateGameTitle(title, newTitle);
                    break;

                case "2": 
                    Console.WriteLine("Enter the new Release Year for the game");

                    string? yearInput = Console.ReadLine();
                    int newYear;

                    if(string.IsNullOrEmpty(yearInput))
                    {
                        Console.WriteLine("New Release Year can not be empty");
                        return;
                    }
                    else 
                    {
                        while(!int.TryParse(yearInput, out newYear))
                        {
                            Console.WriteLine("There was an error with the data submitted, please input the year using numbers");
                            yearInput = Console.ReadLine();
                        }
                    }
                    model.UpdateGameYear(title, newYear);
                    break;

                case "3": 
                    Console.WriteLine("Enter the new Genre for the game");

                    string? newGenre = Console.ReadLine();

                    if(string.IsNullOrEmpty(newGenre))
                    {
                        Console.WriteLine("New Release Year can not be empty");
                        return;
                    }
                    model.UpdateGameGenre(title, newGenre);
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again");
                    break;
            }
        }
    }

}
