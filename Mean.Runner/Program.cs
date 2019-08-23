using System;
using Mean.Language;

namespace Mean.Runner
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //MeanCheck.Run("2 + 3 * 4");
            //MeanCheck.Run("true + false * true");

            MeanCheck.Check("a<b>.x<y>.z.0.u<v>");

            Console.ReadKey(true);
        }
    }
}
