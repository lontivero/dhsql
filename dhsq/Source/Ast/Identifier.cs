using System;
using System.Collections.Generic;
using System.Text;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public class Identifier : IVisitableNode
    {
        public string Name
        {
            get;
            set;
        }

        #region IVisitableNode Members

        public void Accept(AbstractVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.VisitIdentifier(this);
        }

        #endregion
    }
}
