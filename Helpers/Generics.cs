namespace CliMenu.Helpers
{
    public static class Generics
    {
        public static int LoopVariable(int var, int maxValue)
        {
            if (var > maxValue)
            {
                return 0;
            }

            return var;
        }
    }
}