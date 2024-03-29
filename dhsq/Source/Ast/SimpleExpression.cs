﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public class SimpleExpression : Expression
    {
        public ComparationOperators Operator
        {
            get;
            set;
        }

        #region IVisitableNode Members

        public override void Accept(AbstractVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.VisitSimpleExpression(this);
        }

        #endregion
    }
}
