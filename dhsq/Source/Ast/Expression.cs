using System;
using System.Collections.Generic;
using System.Text;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public abstract class Expression : IVisitableNode
    {
        public IVisitableNode Left
        {
            get;
            set;
        }

        public IVisitableNode Right
        {
            get;
            set;
        }
        #region IVisitableNode Members

        public abstract void Accept(AbstractVisitor visitor);

        #endregion
    }
}
