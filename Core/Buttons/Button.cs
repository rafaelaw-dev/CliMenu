using CliMenu.Interfaces;

namespace CliMenu.Core.Buttons
{
    public class Button(Delegate action, object[]? args, IDisplayer displayer) : IButton
    {
        public void Execute()
        {
            action.DynamicInvoke(args ?? []);
        }

        public void Display() => displayer.Display();
    }
}