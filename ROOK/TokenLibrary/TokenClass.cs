using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Token_Library
{
    public abstract class TokenClass
    {
        int lines;
        string tokens;
        string lexemes;
        string description;

        public void setTokens(string token)
        {
            this.tokens = token;
        }
        public string getTokens()
        {
            return this.tokens;
        }
        public void setLexemes(string lexeme)
        {
            this.lexemes = lexeme;
        }
        public string getLexemes()
        {
            return this.lexemes;
        }
        public void setLines(int line)
        {
            this.lines = line;
        }
        public int getLines()
        {
            return this.lines;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
        public string getDescription()
        {
            return this.description;
        }
    }
}
