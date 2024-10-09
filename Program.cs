namespace MVC;

class Program
{
    static void Main(string[] args)
    {
        // Initialize Model, View & Controller
        Model model = new Model();
        View view = new View();
        Controller controller = new Controller(model, view);

        // Start the program
        controller.Run();
    }
}