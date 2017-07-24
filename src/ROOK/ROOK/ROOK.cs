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
            int error = 0, id = 0;
            gvLexical.Rows.Clear();
            gvLexicalErrors.Rows.Clear();

            foreach (var token in lex.tokens)
            {
                if (token.getTokens() == "INVALID")
                {
                    error++;
                    gvLexicalErrors.Rows.Add(error, "Invalid input: "
                                + token.getLexemes()
                                + " on line "
                                + token.getLines() + "\n");
                }
                else if (token.getTokens() == "No Delimiter")
                {
                    error++;
                    gvLexicalErrors.Rows.Add(error, "Proper delimiter expected: "
                                + token.getLexemes()
                                + " on line "
                                + token.getLines() + "\n");
                }
                else if (token.getTokens() == "I Exceeded")
                {
                    error++;
                    gvLexicalErrors.Rows.Add(error, "Identifier exceeded: "
                                + token.getLexemes()
                                + " on line "
                                + token.getLines() + "\n");
                }
                else
                {
                    id++;
                    gvLexical.Rows.Add(id, token.getTokens(), token.getLexemes(), token.getDescription());
                }
            }
        }
    }
}
