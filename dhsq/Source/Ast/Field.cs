﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public sealed class Field : IVisitableNode
    {
        public string XPath
        {
            get;
            set;
        }

        public Identifier Alias
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

            visitor.VisitField(this);
        }

        #endregion
    }
}
