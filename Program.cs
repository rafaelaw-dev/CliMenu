using CliMenu.Display.LowLevel;
using CliMenu.Helpers;

TerminalBuffer buffer = new(new());
buffer.UpdateTerminal("lol \n lol");
Console.ReadKey();
buffer.UpdateTerminal("lmao");
Console.ReadKey();
buffer.Restart();
buffer.UpdateTerminal(AlignText.Align("POGGERS SHADOW BUT", Console.WindowWidth/2, 5));
Console.ReadKey();
buffer.UpdateTerminal("rafaelaw");
Console.ReadKey();
buffer.Exit();

