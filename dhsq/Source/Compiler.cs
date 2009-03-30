
using Antlr.Runtime.Tree;
using System;
using System.IO;
using Antlr.Runtime;
using System.Text;
using Antlr.StringTemplate;
using Antlr.StringTemplate.Language;

using Motorola.PublicSafety.Platform.DHStore.Compiler;


namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    class Compiler
    {
        static public CommonTreeNodeStream nodes;

        static bool single_error_fatal = false;
        static bool error_occurred = false;

        static public void PrintError(String s)
        {
            Console.WriteLine(s);
            error_occurred = !single_error_fatal;

            if (single_error_fatal) Environment.Exit(-1);
        }

        static public void CheckErrors()
        {
            if(error_occurred) Environment.Exit(-1);
        }

        public static void Main(String[] args)
        {
            ANTLRFileStream input = new ANTLRFileStream(args[0], Encoding.ASCII);

            //Lexer
            DhsqLexer lexer = new DhsqLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);

            //Parser and AST construction
            DhsqParser parser = new DhsqParser(tokens);
            DhsqParser.query_return result = parser.query();

            var visitor = new TraceVisitor();
            result.StatementValue.Accept(visitor);

            CommonTree tree = (CommonTree)result.Tree;
            Console.Write(tree.ToStringTree());
            CheckErrors();
        }
    }
}
