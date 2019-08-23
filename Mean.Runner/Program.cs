using System;
using Mean.Language;

namespace Mean.Runner
{
    public static class Program
    {
        static void Main(string[] args)
        {
            MeanCheck.Run("2 + 3 * 4");
            MeanCheck.Run("true + false * true");

            Console.ReadKey(true);
        }
    }
}
