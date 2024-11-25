public class View
{
    public void Display(Model model)
    {
        //debug message
        Console.WriteLine("::DEBUG MESSAGE:: Displaying the model!");
        //prod message
        Console.WriteLine(model.ToString());
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}