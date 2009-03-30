using System;
using System.Collections.Generic;
using System.Text;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public class LogicExpression : Expression
    {
        public LogicOperators Operator
        {
            get;
            set;
        }

        #region IVisitableNode Members

        public override void Accept(AbstractVisitor visitor)
        {
            visitor.VisitLogicExpression(this);
        }

        #endregion

    }
}
