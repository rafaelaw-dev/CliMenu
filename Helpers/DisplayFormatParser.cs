namespace CliMenu.Helpers
{
    /// <summary>
    /// Provides functionality for parsing and replacing placeholder tokens in a string.
    /// </summary>
    public static class DisplayFormatParser
    {
        /// <summary>
        /// Replaces tokens in the given text using values from the provided dictionary.
        /// </summary>
        /// <param name="text">The input string containing tokens like &lt;label&gt;, &lt;symbol&gt;, etc.</param>
        /// <param name="parseCode">Dictionary containing token keys and their corresponding replacement values.</param>
        /// <returns>The text with tokens replaced by their actual values.</returns>
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
