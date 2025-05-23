EasyButton button = new EasyButton((string text) => Console.WriteLine(text), [], new ButtonDisplayer(new ButtonVisual("lol", ConsoleColor.Blue, 'a')));
EasyButton[] buttons = [button];

button.Display();