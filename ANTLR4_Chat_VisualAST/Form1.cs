using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.Windows.Forms;
using EntMapping.Utility;


namespace ANTLR4_Chat_VisualAST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output;
            string inputString = textBox1.Text;
            ICharStream inputStream = new AntlrInputStream(inputString.ToString());
            ITokenSource speakLexer = new SpeakLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(speakLexer);
            SpeakParser speakParser = new SpeakParser(commonTokenStream);            
            speakParser.BuildParseTree = true;
            ParserRuleContext context = speakParser.chat();
            output = context.ToString(speakParser.RuleNames);
            IParseTree tree = speakParser.chat();
            
            var treeNodeDrawable = new ASTTreeNode(tree, speakParser, "1Node");
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            Image image = new VisualAST(treeNodeDrawable).Draw();
            pictureBox1.Image = image;
            textBox1.Text = output;
        }
    }
}
