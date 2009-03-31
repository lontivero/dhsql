using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public abstract class AbstractVisitor
    {
        public virtual IEnumerable VisitSelect(SelectStatement node)
        {
            foreach (var field in node.Fields)
            {
                field.Accept(this);
            }

            if (node.Where != null)
            {
                node.Where.Accept(this);
            }

            return null;
        }

        public virtual void VisitField(Field node)
        {
            if (node.Alias != null)
            {
                node.Alias.Accept(this);
            }
        }

        public abstract void VisitIdentifier(Identifier identifier);

        public virtual void VisitSimpleExpression(SimpleExpression expression)
        {
            expression.Left.Accept(this);
            expression.Right.Accept(this);
        }
    
        public virtual void VisitLogicExpression(LogicExpression expression)
        {
            expression.Left.Accept(this);
            expression.Right.Accept(this);
        }

        public abstract void VisitValue(Value value);
    }
}
