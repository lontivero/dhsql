using System;
using System.Collections.Generic;
using System.Text;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public class Value : IVisitableNode
    {
        public string Val
        {
            get;
            set;
        }

        #region IVisitableNode Members

        public void Accept(AbstractVisitor visitor)
        {
            visitor.VisitValue(this);
        }

        #endregion
    }
}
