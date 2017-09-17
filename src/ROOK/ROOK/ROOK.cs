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
using System.Collections;

namespace ROOK
{
    public partial class ROOK : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public ROOK()
        {
            InitializeComponent();
            forDesign();
           
        }

        private void btnRn_Click_1(object sender, EventArgs e)
        {
            LexicalInitializer lexical = new LexicalInitializer();
            LexicalAnalyzer lex = new LexicalAnalyzer();
            if (!txtCode.Text.Equals(""))
            {
                string code = txtCode.Text;
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
                else
                {
                    id++;
                    gvLexical.Rows.Add(id, token.getLexemes(), token.getTokens(), token.getDescription());
                }
            }

            lblStatus.Text = "Lexical Completed";
        }

        private void forDesign()
        {
            gvLexicalErrors.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI",8 );
            gvLexical.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 8);
        }
        
    }
}
