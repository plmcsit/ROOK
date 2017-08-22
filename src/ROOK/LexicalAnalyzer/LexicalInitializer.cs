using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexical_Analyzer
{
    public class LexicalInitializer
    {
        public int toks = 0;
        Boolean isEnd;

        public LexicalAnalyzer Start(string code, LexicalAnalyzer lex)
        {
            Tokens t = new Tokens();
            Boolean d;
           
            while((!code.Equals(""))&&(!isEnd))
            {
                if (lex.isSpace(code, toks))
                {
                    code = code.Remove(0, lex.ctra);
                    toks--;
                }
                else if (lex.ReservedWords(code)) code = code.Remove(0, lex.ctra);
                else if (lex.Comment(code)) code = code.Remove(0, lex.ctra);
                else if (lex.ReservedSymbols(code)) code = code.Remove(0, lex.ctra);
                else if (lex.hasLiterals(code)) code = code.Remove(0, lex.ctra);
                else if (lex.hasIdentifier(code)) code = code.Remove(0, lex.ctra);
                else
                {
                    t = new Tokens();
                    if (lex.choice != 0)
                    {
                        switch (lex.choice)
                        {
                            case 1:
                                lex.ctra = GetCtr(code, 1);
                                break;
                        }
                    }
                    if (lex.ctra == 0 && code.Length != 1) lex.ctra = GetCtr(code);
                    else if (lex.ctra == 0 && code.Length == 1) lex.ctra = 1;
                    else if (lex.ctra >= code.Length) lex.ctra = code.Length;
                    t.setTokens("INVALID");
                    t.setLexemes(code.Substring(0, lex.ctra));
                    lex.tokens.Add(t);
                    code = code.Remove(0, lex.ctra);
                }
                toks++;
                isEnd = lex.isEnd();
            }


            lex.linetokens.Add(toks);
            lex = setLines(lex);

            return lex;
        }

        private LexicalAnalyzer setLines(LexicalAnalyzer lex)
        {
            for (int ctr = 0; ctr < lex.tokens.Count; ctr++)
            {
                for (int i = 0; i < lex.linetokens.Count; i++)
                {
                    if (ctr + 1 <= lex.linetokens[i])
                    {
                        lex.tokens[ctr].setLines(i + 1);
                        break;
                    }
                }
            }
            return lex;
        }


        //GET CTRS
        private int GetCtr(string txt)
        {
            LexicalConstants.ReservedWordsDelim rwd = new LexicalConstants.ReservedWordsDelim();
            Boolean ifEnd = false;
            int ctr = 0;

            foreach (var item in rwd.whitespace)
            {
                if (txt.ElementAt(ctr) == item)
                    ifEnd = true;
            }
            while (ifEnd != true)
            {
                foreach (var item in rwd.whitespace)
                {
                    if ((txt.Length) > ctr)
                    {
                        if (txt.ElementAt(ctr) == item)
                        {
                            ifEnd = true;
                            break;
                        }
                    }
                    else ifEnd = true;
                }
                if (ifEnd != true)
                    ctr++;
            }

            if (!(txt.Length >= ctr)) ctr--;
            return ctr;
        }

        private int GetCtr(string txt, int ctr)
        {
            Boolean notEnd = true;
            List<char> delims = new List<char> { '"', '\\', '\n' };
            while (notEnd && (txt.Length - 1) >= ctr)
            {
                foreach (char c in delims)
                {
                    if ((txt.Length - 1) > ctr)
                    {
                        if (c == txt.ElementAt(ctr))
                        {
                            notEnd = false;
                            if (c == '\\')
                                if (txt.Length - 1 != ctr)
                                    ctr++;
                        }
                    }
                    else
                        notEnd = false;
                }
                ctr++;
            }
            return ctr;
        }

       
}
}
