using CliMenu.Source.Components;


public class Program
{
    public static void Main()
    {
        ActionButton ac = new("button", "text");

        ac.AddCallback((sender, e) => Console.WriteLine("lol"));

        ac.Execute();
    }   
}