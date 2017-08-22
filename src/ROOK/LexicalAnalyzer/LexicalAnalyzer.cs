using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Token_Library;

namespace Lexical_Analyzer
{
    public class Tokens : TokenClass
    {

    }
    public class LexicalAnalyzer
    {
        public List<Tokens> tokens = new List<Tokens>();
        public List<int> linetokens = new List<int>();
        public int ctra = 0, choice = 0;
        int idNum = 1, lines = 1;
        Boolean checkEnd = false;

        public Boolean isSpace(string txt, int tnum)
        {
            Boolean hasSpace = false;
            if (txt.ElementAt(0) == ' ')
            {
                ctra = 1;
                hasSpace = true;
            } 
            else if (txt.ElementAt(0) == '\n')
            {
                    lines++;
                    ctra = 1;
                    linetokens.Add(tnum);
                    hasSpace = true;
            }
            else if (txt.ElementAt(0) == '\t')
            {
                ctra = 1;
                hasSpace = true;
            }
            return hasSpace;
        }

        public Boolean ReservedWords(string txt)
        {
            LexicalInitializer lexI = new LexicalInitializer();
            LexicalConstants.ReservedWords resWord = new LexicalConstants.ReservedWords();
            LexicalConstants.ReservedWordsDelim resWordDelim = new LexicalConstants.ReservedWordsDelim();
            Tokens token = new Tokens();
            
            List<string> words = new List<string>();
            List<char> delims = new List<char>();
            List<string> temp = new List<string>();

            Boolean hasReservedWord = false, hasToken = false, exit = false;

            int limit = 0, flag = -1, ctr=0;
            string wordComp;

            // Gets the size of the entered word
            // Separate it from other words
            for (int a = 0; a < txt.Length; a++)
            {
                
                foreach (char end in resWordDelim.rw_ender)
                {
                    if (end == txt.ElementAt(a))
                    {
                        if (a == 0)
                        {
                            if (txt.ElementAt(a) == '!') break;
                        }
                        if (a == 3)
                        {
                            if (txt.ElementAt(0) == 'E' && txt.ElementAt(1) == 'N' && txt.ElementAt(2) == 'D' && txt.ElementAt(a) == '!')
                                break;
                        }
                        
                        hasToken = true;
                    }
                }
                if (hasToken == true) break;
                flag++;
            }

            hasToken = false;

            for (int i = 0; i < 6; i++)
            {
                ctr = 0;
                switch (i)
                {
                    case 0:
                        words = resWord.rw_whitespace;
                        delims = resWordDelim.whitespace;
                        break;
                    case 1:
                        words = resWord.rw_1;
                        delims = resWordDelim.delim_1;
                        break;
                    case 2:
                        words = resWord.rw_2;
                        delims = resWordDelim.delim_2;
                        break;
                    case 3:
                        words = resWord.rw_3;
                        delims = resWordDelim.delim_3;
                        break;
                    case 4:
                        words = resWord.rw_4;
                        delims = resWordDelim.delim_4;
                        break;
                    case 5:
                        words = resWord.rw_boolean;
                        delims = resWordDelim.delim_boolean;
                        break;
                    default:
                        break;
                }

                foreach (char t in txt)
                {
                    hasReservedWord = false;
                    limit = words.Count - 1;
                    foreach (string word in words.ToList())
                    {
                        if((word.Length-1) >= ctr)
                        {
                            if(t == word.ElementAt(ctr))
                            {
                                hasReservedWord = true;
                                if(word.Length == flag+1)
                                {
                                    if ((flag) == ctr)
                                    {
                                        wordComp = txt.Substring(0, ctr+1);
                                        if(word == wordComp)
                                        {
                                            if (word == "END!") checkEnd = true;
                                            foreach (char delim in delims)
                                            {
                                                if ((txt.Length - 1) > ctr)
                                                {

                                                    if (txt[flag + 1] == delim)
                                                    {
                                                        hasToken = true;
                                                        if ((word == "true") || (word == "false"))
                                                        {
                                                            token.setTokens("booleanlit");
                                                        }
                                                        else token.setTokens(word);
                                                        token.setLexemes(word);
                                                        token.setDescription(word);
                                                        tokens.Add(token);
                                                    }
                                                }
                                                else if (word == words[limit] && hasToken == false)
                                                {
                                                    hasReservedWord = false;
                                                }
                                                else if (hasToken) break;
                                            }
                                            if (hasToken == false)
                                            {
                                                hasToken = true;
                                                hasReservedWord = true;
                                                token.setTokens("No Delimiter");
                                                token.setLexemes(word);
                                                token.setDescription(word);
                                                tokens.Add(token);
                                                break;
                                            }
                                            if (hasToken)
                                            {
                                                break;
                                            }
                                        }
                                        
                                    }
                                    else temp.Add(word);
                                }
                            }
                        }
                    }
                    ctr++;
                    words = temp;
                    if (!hasReservedWord) break;
                    if (hasToken)
                    {
                        exit = true;
                        break;
                    }
                }
                if (exit) break;
            }



            ctra = ctr;
            return hasToken;
        }

        public Boolean Comment(string txt)
        {
            int ctr=0;
            Boolean isComment = false, endComment = false;
            if (txt.Length > 2)
            {
                if (txt.ElementAt(0) == '/' && txt.ElementAt(1) == '/')
                {
                    ctr = 1;
                    while (!endComment)
                    {
                        if (txt.Length - 1 > ctr)
                        {
                            if (txt.ElementAt(ctr + 1) == '\n')
                            {
                                endComment = true;
                            }
                        }
                        else endComment = true;
                       isComment = true;
                       ctr++;
                    }
                    lines++;
                }
            }
            ctra = ctr;
            return isComment;
        }

        public Boolean ReservedSymbols(string txt)
        {
            LexicalConstants.ReservedWordsDelim resWordDelim = new LexicalConstants.ReservedWordsDelim();
            LexicalConstants.ReservedSymbols resSym = new LexicalConstants.ReservedSymbols();
            LexicalConstants.ReservedSymbolsDelims resSymDelim = new LexicalConstants.ReservedSymbolsDelims();
            Tokens token = new Tokens();

            List<string> sym = new List<string>();
            List<char> delims = new List<char>();
            List<string> temp = new List<string>();

            Boolean hasReservedSymbol, hasToken = false, exit = false;

            int flag = -1, limit, ctr=0;

            for (int a = 0; a < txt.Length; a++)
            {

                foreach (char end in resSymDelim.rs_ender)
                {
                    if (end == txt.ElementAt(a))
                    {
                        hasToken = true;
                    }
                }
                if (hasToken) break;
                flag++;
            }

            if (flag < 0)
            {
                foreach (char one in resSymDelim.rs_one)
                {
                    if (txt.ElementAt(0) == one)
                    {
                        flag++;
                        break;
                    }
                }
            }
            if (txt.Length > 1)
            {
                if (flag == 0)
                {
                    if (txt.ElementAt(1) == '=')
                    {
                        foreach (char repeat in resSymDelim.rs_repeat)
                        {
                            if (txt.ElementAt(0) == repeat)
                            {
                                flag++;
                                break;
                            }
                        }
                    }
                    else if (txt.ElementAt(1) == '+') if (txt.ElementAt(0) == '+') flag++;
                    if (txt.ElementAt(1) == '-') if (txt.ElementAt(0) == '-') flag++;
                }
            }

            hasToken = false;

            for (int i = 0; i < 13; i++)
            {
                ctr = 0;
                switch (i)
                {
                    case 0:
                        sym = resSym.rs_2;
                        delims = resWordDelim.delim_2;
                        break;
                    case 1:
                        sym = resSym.rs_5;
                        delims = resSymDelim.delim_5;
                        break;
                    case 2:
                        sym = resSym.rs_7;
                        delims = resSymDelim.delim_7;
                        break;
                    case 3:
                        sym = resSym.rs_8;
                        delims = resSymDelim.delim_8;
                        break;
                    case 4:
                        sym = resSym.rs_9;
                        delims = resSymDelim.delim_9;
                        break;
                    case 5:
                        sym = resSym.rs_whitespace;
                        delims = resWordDelim.whitespace;
                        break;
                    case 6:
                        sym = resSym.rs_arithop;
                        delims = resSymDelim.delim_arithop;
                        break;
                    case 7:
                        sym = resSym.rs_incop;
                        delims = resSymDelim.delim_incop;
                        break;
                    case 8:
                        sym = resSym.rs_lower;
                        delims = resSymDelim.delim_lower;
                        break;
                    case 9:
                        sym = resSym.rs_11;
                        delims = resSymDelim.delim_11;
                        break;
                    case 10:
                        sym = resSym.rs_12;
                        delims = resSymDelim.delim_12;
                        break;
                    case 11:
                        sym = resSym.rs_13;
                        delims = resSymDelim.delim_13;
                        break;
                    case 12:
                        sym = resSym.rs_14;
                        delims = resSymDelim.delim_14;
                        break;
                    default:
                        break;
                }

                foreach (char t in txt)
                {
                    hasReservedSymbol = false;
                    limit = sym.Count - 1;
                    foreach (string symbol  in sym.ToList())
                    {
                        if((symbol.Length-1) >= ctr)
                        {
                            if(t == symbol.ElementAt(ctr))
                            {
                                hasReservedSymbol = true;
                                if(symbol.Length == (flag + 1))
                                {
                                    if (flag == ctr)
                                    {
                                        foreach(char delim in delims)
                                        {
                                            if ((txt.Length - 1) > ctr)
                                            {

                                                if (txt[flag + 1] == delim)
                                                {
                                                    hasToken = true;
                                                    token.setTokens(symbol);
                                                    token.setLexemes(symbol);
                                                    token.setDescription(symbol);
                                                    tokens.Add(token);
                                                }
                                            }
                                            else if (symbol == sym[limit] && hasToken == false) hasReservedSymbol = false;
                                            else if (hasToken) break;
                                        }
                                    }
                                    else temp.Add(symbol);
                                }
                            }
                        }
                    }
                    ctr++;
                    sym = temp;
                    if(!hasReservedSymbol)break;
                    if (hasToken)
                    {
                        exit = true;
                        break;
                    }
                }
                if (exit) break;
            }
            ctra = ctr;
            return hasToken;
        } 

        public Boolean hasLiterals(string txt)
        {
            
            LexicalConstants.Literals lit = new LexicalConstants.Literals();
            LexicalConstants.LiteralsDelim litDelim = new LexicalConstants.LiteralsDelim();
            Tokens token = new Tokens();

            List<char> delims = new List<char>();

            string strlit = "";

            Boolean hasToken = false, validstr = false, numNext = true, decLit = false, numLit = false, isNum = true, isStr = true, isNeg = false;

            int ctr = 0, digitNum = 0, digitDec = 0;

            choice = 0;

            if (txt.ElementAt(0).Equals('"')) choice = 1;
            else
            {
                foreach (char num in lit.number)
                {
                    if(txt.ElementAt(0) == num)
                    {
                        choice = 2;
                        break;
                    }
                }
            }

            switch (choice)
            {
                case 1:
                    if (!txt.Length.Equals(1))
                    {
                        while ((txt.Length - 1) > ctr && !txt.ElementAt(ctr+1).Equals('"'))
                        {
                            strlit += txt[ctr];
                            ctr++;
                        }
                        
                        if (ctr + 1 == txt.Length) isStr = false;

                        if (isStr)
                        {
                            if (txt.ElementAt(0).Equals('"') && txt.ElementAt(ctr + 1).Equals('"'))
                            {
                                ctr += 2;
                                validstr = true;
                                foreach (char delim in litDelim.delim_str)
                                {
                                    if (txt.Length >= ctr + 1)
                                    {
                                        if (txt.ElementAt(ctr).Equals(delim))
                                        {
                                            hasToken = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        if (hasToken && validstr)
                        {
                            token.setTokens("stringlit");
                            token.setLexemes(txt.Substring(0, ctr));
                            token.setDescription("stringlit");
                            tokens.Add(token);
                        }
                        else if (!hasToken && validstr)
                        {
                            hasToken = true;
                            token.setTokens("No Delimiter");
                            token.setLexemes(txt.Substring(0, ctr));
                            token.setDescription("stringlit");
                            tokens.Add(token);
                        }
                        else if (!validstr) hasToken = false;

                    }
                    break;
                case 2:
                    if(txt.ElementAt(0) == '~')
                    {
                        ctr++;
                        isNeg = true;
                        isNum = false;
                        while (numNext)
                        {
                            foreach (char no in lit.number)
                            {
                                if ((txt.Length - 1) >= ctr)
                                {
                                    if (txt.ElementAt(ctr) == no)
                                    {
                                        numLit = true;
                                        numNext = true;
                                        isNum = true;
                                        ctr++;
                                        digitNum++;
                                        break;
                                    }
                                    else
                                    {
                                        numNext = false;
                                    }
                                }
                                else
                                {
                                    numNext = false;
                                }
                            }
                        }
                    }
                    else
                    {
                       numLit = true;
                       while((txt.Length - 1 >= ctr) && numNext)
                        {
                            foreach (char no in lit.num)
                            {
                                if ((txt.Length - 1) >= ctr)
                                {
                                    if (txt.ElementAt(ctr) == no)
                                    {
                                        numNext = true;
                                        isNum = true;
                                        ctr++;
                                        digitNum++;
                                        break;
                                    }
                                    else
                                    {
                                        numNext = false;
                                    }
                                }
                            }
                        }
                    }

                    if((txt.Length - 1) > ctr)
                    {
                        if (txt.ElementAt(ctr) == '.')
                        {
                            numNext = true;
                            foreach (char no in lit.num)
                            {
                                if (txt.ElementAt(ctr + 1) == no)
                                {
                                    numLit = false;
                                    decLit = true;
                                    ctr++;
                                    break;
                                }
                            }
                            while ((txt.Length > ctr) && numNext)
                            {
                                foreach (char no in lit.num)
                                {
                                    if (txt.ElementAt(ctr) == no)
                                    {
                                        ctr++;
                                        digitDec++;
                                        numNext = true;
                                        break;
                                    }
                                    else
                                    {
                                        numNext = false;
                                    }
                                }
                            }
                        }
                    }

                  
                    if (numLit && digitNum > 9)
                    {
                        if ((isNeg == true) && (numLit && digitNum <= 10)) break;
                        hasToken = true;
                        token.setTokens("Over the limit");
                        token.setLexemes(txt.Substring(0, ctr));
                        token.setDescription("numberlit");
                        tokens.Add(token);
                    }
                    else if(numLit)
                    {
                        foreach(char delim in litDelim.delim_num)
                        {
                            if((txt.Length - 1) >= ctr)
                            {
                                if (txt.ElementAt(ctr) == delim)
                                {
                                    hasToken = true;
                                    break;
                                }
                            } 
                        }
                        if (hasToken)
                        {
                            token.setTokens("numberlit");
                            token.setLexemes(txt.Substring(0, ctr));
                            token.setDescription("numberlit");
                            tokens.Add(token);
                        }
                        else
                        {
                            hasToken = true;
                            token.setTokens("No Delimiter");
                            token.setLexemes(txt.Substring(0, ctr));
                            token.setDescription("numberlit");
                            tokens.Add(token);
                        }
                    }
                    else if(decLit && ((digitNum > 9) || digitDec > 5))
                    {
                        if ((isNeg == true) && decLit && ((digitNum <= 10) && digitDec <= 5)) break;
                        token.setTokens("decimallit");
                        token.setLexemes(txt.Substring(0, ctr));
                        token.setDescription("decimallit");
                        tokens.Add(token);
                    }
                    else if (decLit)
                    {
                        foreach (char delim in litDelim.delim_dec)
                        {
                            if ((txt.Length - 1) >= ctr)
                            {
                                if (txt.ElementAt(ctr) == delim)
                                {
                                    hasToken = true;
                                    break;
                                }
                            }
                        }
                        if (hasToken)
                        {
                            token.setTokens("decimallit");
                            token.setLexemes(txt.Substring(0, ctr));
                            token.setDescription("decimallit");
                            tokens.Add(token);
                        }
                        else
                        {
                            hasToken = true;
                            token.setTokens("No Delimiter");
                            token.setLexemes(txt.Substring(0, ctr));
                            token.setDescription("decimallit");
                            tokens.Add(token);
                        }
                    }

                    break;
            }

            ctra = ctr;
            return hasToken;
        }
        public Boolean hasIdentifier(string txt)
        {
            LexicalConstants.Identifiers id = new LexicalConstants.Identifiers();
            LexicalConstants.IdentifiersDelims idDelims = new LexicalConstants.IdentifiersDelims();

            Tokens token = new Tokens();

            List<char> delims = new List<char>();

            int ctr = 0;

            Boolean isID = false, validID = true, hasToken = false, moreThan = false;

            foreach(char c in id.lowercase)
            {
                if(txt.ElementAt(0) == c)
                {
                    isID = true;
                    break;
                }
            }

            if (isID)
            {
                while (validID)
                {
                    validID = false;
                    foreach (char n in id.allIn)
                    {
                        if ((txt.Length - 1) >= ctr)
                            if (txt.ElementAt(ctr) == n)
                            {
                                ctr++;
                                validID = true;
                            }
                    }
                    if (ctr > 10)
                        moreThan = true;
                }

                if (isID)
                {
                    foreach (char delim in idDelims.delim_id)
                    {
                        if ((txt.Length - 1) >= ctr)
                            if (txt.ElementAt(ctr) == delim)
                            {
                                hasToken = true;
                                break;
                            }
                    }
                }

                if (moreThan)
                {
                    token.setTokens("I Exceeded");
                    token.setLexemes(txt.Substring(0, (ctr)));
                    token.setDescription("identifier" + idNum);
                    tokens.Add(token);
                    idNum++;
                }

                else if (hasToken)
                {
                    token.setTokens("id");
                    token.setLexemes(txt.Substring(0, (ctr)));
                    token.setDescription("identifier" + idNum);
                    tokens.Add(token);
                    idNum++;
                }
            }
            ctra = ctr;
            return hasToken;
        }

        public Boolean isEnd()
        {
            return checkEnd;
        }
    }
}
