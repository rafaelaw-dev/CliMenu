using CliMenu.Abstract.Interfaces.Backend;
using CliMenu.Helpers;

namespace CliMenu.Display.LowLevel
{
    public class TerminalBuffer : ITerminalBuffer
    {
        private string[] previousLines;
        private string[] newLines;
        private readonly TerminalRenderer renderer;

        public TerminalBuffer(TerminalRenderer renderer)
        {
            Console.Clear();
            previousLines = [];
            newLines = [];

            this.renderer = renderer;
            renderer.Initialize();
        }

        public void UpdateTerminal(string newText)
        {
            string[] rawNewTextLines = newText.Split(["\r\n", "\n"], StringSplitOptions.None);
            object[] equalizedNew = Generics.Fill(rawNewTextLines, previousLines.Length - rawNewTextLines.Length, "");

            newLines = equalizedNew.Cast<string>().ToArray();

            int[] differentLines = GetDifferentLinesIndex(previousLines, newLines);

            previousLines = newLines;
            foreach (int i in differentLines)
            {
                renderer.Renderer(i, newLines[i]);
            }
        }

        public void Exit() => Console.Clear();
        public void Restart() => renderer.Restart();
        
        private int[] GetDifferentLinesIndex(string[] lines1, string[] lines2)
        {
            List<int> indexes = [];
            int maxLength = Math.Max(lines1.Length, lines2.Length);

            for (int i = 0; i < maxLength; i++)
            {
                string? line1 = i < lines1.Length ? lines1[i] : null;
                string? line2 = i < lines2.Length ? lines2[i] : null;

                if (line1 != line2)
                {
                    indexes.Add(i);
                }
            }

            return indexes.ToArray();
        }
    }
}