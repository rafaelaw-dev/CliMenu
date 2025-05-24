namespace CliMenu.Helpers
{
    public static class AlignText
    {
        public static string Align(string text, int left, int top)
        {
            return new string('\n', top) + new string(' ', left - text.Length / 2) + text;
        }
    }
}