using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public class TraceVisitor : AbstractVisitor
    {
        public override IEnumerable VisitSelect(SelectStatement node)
        {
            Console.WriteLine("SELECT");
            foreach (var f in node.Fields)
            {
                f.Accept(this);
            }

            if (node.Where != null)
            {
                Console.WriteLine("WHERE");
                node.Where.Accept(this);
            }

            return null;
        }

        public override void VisitField(Field node)
        {
            Console.WriteLine("   {0, -12} AS {1}.text()", node.Alias.Name, node.XPath);  
        }

        public override void VisitIdentifier(Identifier identifier)
        {
            Console.Write(identifier.Name);
        }

        public override void VisitSimpleExpression(SimpleExpression expression)
        {
            Console.Write("   ");
            expression.Left.Accept(this);
            Console.Write(" " + expression.Operator.ToString() + " ");
            expression.Right.Accept(this);
        }

        public override void VisitLogicExpression(LogicExpression expression)
        {
            Console.Write("   ");
            expression.Left.Accept(this);
            Console.Write(" " + expression.Operator.ToString() + " ");
            expression.Right.Accept(this);
        }

        public override void VisitValue(Value value)
        {
            Console.Write(value.Val);
        }
    }
}
