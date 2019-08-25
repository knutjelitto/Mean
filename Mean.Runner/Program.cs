using System;
using Clean.Sources;
using Mean.Language;

namespace Mean.Runner
{
    public static class Program
    {
        static void Main(string[] args)
        {
            new SourceProvider().Provide(Mean.Maker.Builder.BuildTop);

            //CheckPackage();
            //CheckExpression();
            //DumpTree();
            Dump();

            Console.Write("(almost) any key ...");
            Console.ReadKey(true);
        }

        private static void Dump()
        {
            Checker.Dump("namespace test {  }", Parser.Unit);
        }

        private static void DumpTree()
        {
            Checker.DumpTree("namespace test {  }", Parser.Unit);
        }

        private static void CheckPackage()
        {
            Checker.Check("scope test {  }", Parser.Unit);
        }

        private static void CheckExpression()
        {
            Checker.Check("22", Parser.Expression);
            Checker.Check("22.0", Parser.Expression);
            Checker.Check("x.2_0", Parser.Expression);
            Checker.Check("a<b>.x<y,a=b>.z.0.u<v>(x)", Parser.Expression);
            Checker.Check("a<x>[b].c<z>", Parser.Expression);
            Checker.Check("a[b][c].f(x) > 2", Parser.Expression);
            Checker.Check("1 < 2 < 3", Parser.Expression);
            Checker.Check("2 + 3 * 4", Parser.Expression);
            Checker.Check("2 * 3 + 4", Parser.Expression);
            Checker.Check("2 * 3 * 4", Parser.Expression);
            Checker.Check("2 + 3 + 4", Parser.Expression);
        }
    }
}
