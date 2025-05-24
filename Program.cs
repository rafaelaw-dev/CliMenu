EasyButton button = new EasyButton((string text) => Console.WriteLine(text), [], new ButtonDisplayable(new ButtonVisual("lol", ConsoleColor.Blue, 'a')));
EasyButton[] buttons = [button];

Console.WriteLine(button.GetDisplay());