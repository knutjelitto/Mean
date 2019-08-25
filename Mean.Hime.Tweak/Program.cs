using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Mean.Hime.Tweak
{
    public class Program
    {
        private readonly string inputFile;
        private readonly string outputFile;

        static void Main(string[] args)
        {
            var inputFile = args[0];
            var outputFile = args[1];

            var program = new Program(args[0], args[1]);
        }

        public Program(string inputFile, string outputFile)
        {
            this.inputFile = inputFile;
            this.outputFile = outputFile;

            Process();
        }

        private void Process()
        {
            var inlines = File.ReadAllLines(inputFile);
            var outlines = new List<string>();
            outlines.Add($"using Hime.Redist;");
            outlines.Add($"");
            outlines.Add($"namespace {Namespace(inlines)}");
            outlines.Add($"{{");

            //outlines.Add($"\tinternal class {VisitorName()} : {ParserName()}.Visitor");
            outlines.Add($"\tinternal class {VisitorName()}");
            outlines.Add($"\t{{");

            outlines.Add($"\t\tpublic void Visit(ParseResult result)");
            outlines.Add($"\t\t{{");
            outlines.Add($"\t\t\tVisitASTNode(result.Root);");
            outlines.Add($"\t\t}}");

            outlines.Add($"");

            outlines.Add($"\t\tprotected virtual void VisitASTNode(ASTNode node)");
            outlines.Add($"\t\t{{");
            Switch(inlines, outlines);
            outlines.Add($"\t\t}}");
            outlines.Add($"");

            outlines.Add($"\t\tprotected virtual void VisitASTChildren(ASTNode node)");
            outlines.Add($"\t\t{{");
            outlines.Add($"\t\t\tfor (var i = 0; i < node.Children.Count; i++)");
            outlines.Add($"\t\t\t{{");
            outlines.Add($"\t\t\t\tVisitASTNode(node.Children[i]);");
            outlines.Add($"\t\t\t}}");
            outlines.Add($"\t\t}}");

            outlines.Add($"");

            Virtuals(inlines, outlines);

            outlines.Add($"\t}}");

            outlines.Add($"}}");

            File.WriteAllLines(outputFile, outlines);
        }

        private void Switch(IReadOnlyList<string> inlines, IList<string> outlines)
        {
            var start = 0;
            for (; start < inlines.Count; ++start)
            {
                if (inlines[start] == "\t\t\tswitch(node.Symbol.ID)")
                {
                    break;
                }
            }

            for (; start < inlines.Count; ++start)
            {
                var line = inlines[start].Replace("visitor.", string.Empty);

                outlines.Add(line);
                if (line == "\t\t\t}")
                {
                    break;
                }
            }
        }

        private void Virtuals(IReadOnlyList<string> inlines, IList<string> outlines)
        {
            var start = 0;
            for (; start < inlines.Count; ++start)
            {
                if (inlines[start] == "\t\tpublic class Visitor")
                {
                    break;
                }
            }

            start = start + 2;

            for (; start < inlines.Count; ++start)
            {
                var line = inlines[start];

                if (line == "\t\t}")
                {
                    break;
                }

                Virtual(line, outlines);
            }
        }

        private void Virtual(string line, IList<string> outlines)
        {
            line = line.Substring(1); // remove '\t'
            line = line.Replace(" {}", string.Empty);
            outlines.Add($"{line}");
            outlines.Add($"\t\t{{");
            outlines.Add($"\t\t\tVisitASTChildren(node);");
            outlines.Add($"\t\t}}");
        }

        private string Namespace(IReadOnlyCollection<string> lines)
        {
            foreach (var line in lines)
            {
                if (line.StartsWith("namespace"))
                {
                    return line.Substring("namespace ".Length);
                }
            }

            throw new ArgumentOutOfRangeException(nameof(lines));
        }

        private string ParserName()
        {
            return Path.GetFileNameWithoutExtension(inputFile);
        }

        private string VisitorName()
        {
            var name = ParserName();

            return name.Substring(0, name.Length - "Parser".Length) + "Visitor";
        }
    }
}
