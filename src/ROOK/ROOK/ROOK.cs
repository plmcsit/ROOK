using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Token_Library;
using Lexical_Analyzer;

namespace ROOK
{
    public partial class ROOK : Form
    {
        public ROOK()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            LexicalInitializer lexical = new LexicalInitializer();
            LexicalAnalyzer lex = new LexicalAnalyzer();
            if (!Code.Text.Equals(""))
            {
                string code = Code.Text;
                lex = lexical.Start(code, lex);
                 DisplayLexical(lex);
            } 
            else
            {
                // Show Error Message
                MessageBox.Show("");
            }
        }

        private void DisplayLexical(LexicalAnalyzer lex)
        {
            gvLexical.Rows.Clear();

            foreach (var item in lex.tokens)
            {
                gvLexical.Rows.Add(item.getTokens(), item.getLexemes(), item.getDescription());
            }
        }
    }
}
