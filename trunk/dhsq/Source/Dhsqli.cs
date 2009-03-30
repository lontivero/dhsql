using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public class Dhsqli
    {
        public void ExecQuery(string query)
        {
            ICharStream input = new ANTLRStringStream(query);

            //Lexer
            DhsqLexer lexer = new DhsqLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);

            //Parser and AST construction
            DhsqParser parser = new DhsqParser(tokens);
            DhsqParser.query_return result = parser.query();

            var visitor = new TraceVisitor();
            result.StatementValue.Accept(visitor);
        }
    }
}
