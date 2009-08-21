
using System;
using System.IO;
using Antlr.Runtime;
using System.Text;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    class Compiler
    {
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
            string query;
#if !USE_HARDCODE            
            query = @"from Pawns 
                select '/Document/PawnNo' as Number, '/Document/FullName' as Name
                where ((Name = 'Franco') and Number > 10) order by Number";
#else
            query = System.IO.File.ReadAllText("SimpleQuery.dhsq");
#endif
            var interpreter = new Dhsqli();
            var docs = interpreter.ExecQuery(query);
        }
    }
}
