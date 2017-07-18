using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexical_Analyzer
{
    public class LexicalInitializer
    {
        public LexicalAnalyzer Start(string code, LexicalAnalyzer lex)
        {
            Tokens t = new Tokens();

            while(!code.Equals(""))
            {
                if (lex.isSpace(code)) code = code.Remove(0, lex.ctra);
                else if (lex.ReservedWords(code)) code = code.Remove(0, lex.ctra);
                else if (lex.ReservedSymbols(code)) code = code.Remove(0, lex.ctra);
                else if (lex.hasLiterals(code)) code = code.Remove(0, lex.ctra);
                else if (lex.hasIdentifier(code)) code = code.Remove(0, lex.ctra);
            }
            

            
            return lex;
        }
    }
}
