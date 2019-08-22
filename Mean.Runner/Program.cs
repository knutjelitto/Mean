using System;
using Mean.Language;

namespace Mean.Runner
{
    public static class Program
    {
        static void Main(string[] args)
        {
            MeanCheck.Run();

            Console.ReadKey(true);
        }
    }
}
