using System;
using System.Collections.Generic;
using System.Text;

namespace Motorola.PublicSafety.Platform.DHStore.Compiler
{
    public interface IVisitableNode
    {
        void Accept(AbstractVisitor visitor);
    }
}
