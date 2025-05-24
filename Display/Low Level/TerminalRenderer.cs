namespace CliMenu.Display.LowLevel
{
    public class TerminalRenderer 
    {
        public virtual void Initialize()
        {
            for (int i = 0; i < Console.WindowHeight - 1; i++)
            {
                Renderer(i, "\n");
            }
        }

        public virtual void Restart()
        {
            for (int i = 0; i < Console.WindowHeight - 1; i++)
            {
                Renderer(i, new string(' ', Console.WindowWidth));
                Renderer(i, "\n");
            }
        }

        public virtual void Renderer(int i, string text)
        {
            if (i > Console.WindowHeight)
            {
                return;
            }

            if (text == "")
            {
                return;
            }

            Console.SetCursorPosition(0, i);
            Console.Write(text);
            Console.SetCursorPosition(0, Console.WindowHeight);
        }
    }
}