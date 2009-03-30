
using System;
using System.IO;
using Antlr.Runtime;
using System.Text;

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
            var sb = new StringBuilder();
            sb
                .Append("from Agencies ")
                .Append("select ")
                .Append("  '/Person/FirstName' as FirstName, ")
                .Append("  '/Person/Age' as Age, ")
                .Append("  '/Person/Children/Name' as Childs ")
                .Append("where ")
                .Append("((FirstName = 'Franco') and Age > 10)");

            var interpreter = new Dhsqli();
            var docs = interpreter.ExecQuery(sb.ToString());
        }
    }
}
