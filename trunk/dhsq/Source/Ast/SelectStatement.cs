using System;
using System.Collections.Generic;
using System.Text;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public sealed class SelectStatement : IVisitableNode, IStatement
    {
        public Identifier SourceId
        {
            get;
            set;
        }

        public List<Field> Fields
        {
            get;
            set;
        }

        public Where Where
        {
            get;
            set;
        }

        public OrderBy OrderBy
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

            visitor.VisitSelect(this);
        }

        #endregion
    }
}
