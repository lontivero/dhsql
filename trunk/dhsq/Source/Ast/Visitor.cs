using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public abstract class AbstractVisitor
    {
        public abstract IEnumerable VisitSelect(SelectStatement node);

        public abstract void VisitField(Field node);

        public abstract void VisitIdentifier(Identifier identifier);

        public abstract void VisitSimpleExpression(SimpleExpression expression);

        public abstract void VisitLogicExpression(LogicExpression expression);

        public abstract void VisitValue(Value value);
    }
}
