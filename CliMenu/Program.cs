using CliMenu.Components.DefaultComponents;

Console.Clear();

InputField field = new("inputfield", "ShadowBut");

while (true)
{
    Console.Clear();
    Console.WriteLine(field.GetDisplay());
    Console.WriteLine(field.Index);
    ConsoleKeyInfo info = Console.ReadKey();
    field.HandleInput(info);
}