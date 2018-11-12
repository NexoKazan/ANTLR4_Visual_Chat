using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EntMapping.Utility
{
    public interface IASTTreeNode
    {
        string Text { get; }
        string TextDef { get; }        
        int Count { get; }
        IEnumerable<IASTTreeNode> Children { get; }
    }
}
