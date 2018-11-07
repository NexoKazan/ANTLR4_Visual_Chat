using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using Antlr4.Runtime.Tree;
using System.Windows.Forms;


namespace EntMapping.Utility
{
    public class ASTTreeNode : IASTTreeNode
    {
        ITree _tree;
        

        public ASTTreeNode(ITree tree)
        {
            _tree = tree;
        }

        public string Text
        {
           get {
                if (_tree.ChildCount != 0)
                {
                    return "Node";
                }
                else
                {
                    return _tree.ToString();
                }                  
            }
        }
        public string TextDef
        {
            get
            {  return _tree.ToString();
            
            }
        }

        public int Count
        {
            get { return _tree.ChildCount; }
        }

        public IEnumerable<IASTTreeNode> Children
        {
            get
            {
                for (int i = 0; i < _tree.ChildCount; ++i)
                {
                    yield return new ASTTreeNode(_tree.GetChild(i));
                }
            }
        }

    }
}
