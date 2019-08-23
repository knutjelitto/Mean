using System;
using Hime.Redist;

namespace Mean.Language
{
    public static class MeanCheck
    {
        public static void Run(string source)
        {
            var lexer = new MeanLexer(source);
            var parser = new MeanParser(lexer);

            var result = parser.Parse();

            if (!result.IsSuccess)
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine($"{error}");
                }
            }
            else
            {

                Print(result.Root, new bool[] { });
            }
        }

        private static void Print(ASTNode node, bool[] crossings)
        {
            for (var i = 0; i < crossings.Length - 1; i++)
            {
                Console.Write(crossings[i] ? "|   " : "    ");
            }
            if (crossings.Length > 0)
            {
                Console.Write("+-> ");
            }
            Console.WriteLine(node.ToString());

            for (var i = 0; i != node.Children.Count; i++)
            {
                var childCrossings = new bool[crossings.Length + 1];
                Array.Copy(crossings, childCrossings, crossings.Length);
                childCrossings[childCrossings.Length - 1] = (i < node.Children.Count - 1);
                Print(node.Children[i], childCrossings);
            }
        }
    }
}
