namespace CliMenu.Helpers
{
    public static class DisplayFormatParser
    {
        public static string Parse(string text, Dictionary<string, string> parseCode)
        {
            foreach (KeyValuePair<string, string> pair in parseCode)
            {
                text = text.Replace($"<{pair.Key}>", pair.Value);
            }

            return text;
        }
    }
}