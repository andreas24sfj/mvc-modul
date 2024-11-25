namespace mvc_modul;

class Program
{
    static void Main(string[] args)
    {
        Model model = new Model("Kjell T. Ring", 35);
        View view = new View();

        Controller controller = new Controller(model, view);

        // show the model
        controller.ShowModel();

        // update the name
        controller.UpdateName();

        // update the name & age
        controller.UpdateAge();

        // display the updated model
        controller.ShowModel();

        // Keep the console open for input.
        Console.WriteLine("Press Enter to exit the program!");
        Console.ReadLine();
        Console.WriteLine("Program terminated...");
    }
}
