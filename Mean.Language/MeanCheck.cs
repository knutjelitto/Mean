using System;
using System.Linq;
using Hime.Redist;
using Mean.Language.Generated;

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

                PrintTree(result.Root, new bool[] { });
                Console.WriteLine(MakeLisp(result.Root));
            }
        }

        public static void Check(string source)
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

                Console.WriteLine(MakeLisp(result.Root));
            }
        }

        private static void PrintTree(ASTNode node, bool[] crossings)
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
                PrintTree(node.Children[i], childCrossings);
            }
        }

        private static string MakeLisp(ASTNode node)
        {
            if (node.SymbolType == SymbolType.Terminal)
            {
                return node.Value;
            }
            if (node.Children.Count == 1 && node.Children[0].SymbolType == SymbolType.Terminal)
            {
                return node.Children[0].Value;
            }

            var children = string.Join(" ", node.Children.Select(MakeLisp));
            return $"({node.Symbol} {children})";
        }
    }
}
