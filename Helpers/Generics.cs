namespace CliMenu.Helpers
{
    /// <summary>
    /// Provides general-purpose utility methods for handling variables.
    /// </summary>
    public static class Generics
    {
        /// <summary>
        /// Loops a variable within the provided range. 
        /// If it exceeds maxValue, it wraps to minValue.
        /// If it goes below minValue, it wraps to maxValue.
        /// </summary>
        /// <param name="var">The variable to loop.</param>
        /// <param name="maxValue">The maximum value allowed.</param>
        /// <param name="minValue">The minimum value allowed (default is 0).</param>
        /// <returns>The adjusted value within the looped range.</returns>
        public static int LoopVariable(int var, int maxValue, int minValue = 0)
        {
            if (var > maxValue)
            {
                return minValue;
            }

            if (var < minValue)
            {
                return maxValue;
            }

            return var;
        }
    }
}