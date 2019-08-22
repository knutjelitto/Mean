using System;
using Hime.Redist;

namespace Mean.Language
{
    public static class MeanCheck
    {
        public static void Run()
        {
            var lexer = new MeanLexer("2 + 3 * 4");
            var parser = new MeanParser(lexer);

            var result = parser.Parse();

            Print(result.Root, new bool[] { });
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
