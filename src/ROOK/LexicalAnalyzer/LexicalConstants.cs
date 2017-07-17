using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexical_Analyzer
{
    public class LexicalConstants
    {
        public class ReservedWords
        {
            public List<string> rw_whitespace = new List<string> { "boolean", "choice", "decimal", "do", "else"
                                                , "END!", "file", "fixed", "number", "read", "start", "string"
                                                , "!START" };
            public List<string> rw_1 = new List<string> { "end", "jump", "nl", "null", "stop", "tab" };
            public List<string> rw_2 = new List<string> { "elseif", "for", "if", "return", "switch", "while", "write" };
            public List<string> rw_3 = new List<string> { "and", "or" };
            public List<string> rw_4 = new List<string> { "default" };
            public List<string> rw_boolean = new List<string> { "true", "false" };
        }
        public class ReservedWordsDelim
        {
            public List<char> whitespace = new List<char> { ' ','\r','\n','\t' };
            public List<char> delim_1 = new List<char> { ' ', '\r', '\n', '\t', '.' };
            public List<char> delim_2 = new List<char> { ' ', '\r', '\n', '\t', '(' };
            public List<char> delim_3 = new List<char> { ' ', '\r', '\n', '\t', '(', '!' };
            public List<char> delim_4 = new List<char> { ' ', '\r', '\n', '\t', ':' };
            public List<char> delim_boolean = new List<char> { ' ', '\r', '\n', '\t', '.', ',', ')' };
            public List<char> rw_ender = new List<char> {  ' ', '\r', '\n', '\t', '.', ',', ')', ':', '(', '!' };
        }

        /* Reserved Symbols */
        public class ReservedSymbols
        {
            public List<string> rs_2 = new List<string> { "!" };
            public List<string> rs_5 = new List<string> { "!=", "=", "==", "[" };
            public List<string> rs_7 = new List<string> { "," };
            public List<string> rs_8 = new List<string> { "]" };
            public List<string> rs_9 = new List<string> { ")" };
            public List<string> rs_whitespace = new List<string> { "." };
            public List<string> rs_arithop = new List<string> { "+", "+=", "-", "-=", "*", "*=", "/", "/="
                                    , ">", ">=", "<", "<=", "(", "%" };
            public List<string> rs_incop = new List<string> { "++", "--" };
            public List<string> rs_lower = new List<string> { "@" };
        }
        public class ReservedSymbolsDelims
        {
            public List<char> delim_arithop = new List<char> { '\r', '\n', '\t', ' ', '(', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'
                                            , 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u','v'
                                            , 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            public List<char> delim_5 = new List<char> { '\r', '\n', '\t', ' ', '(', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'
                                            , 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u','v'
                                            , 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '"' };
            public List<char> delim_incop = new List<char> { '\r', '\n', '\t', ' ', '(', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'
                                            , 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u','v'
                                            , 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', ',' };
            public List<char> delim_7 = new List<char> { '\r','\n', '\t', ' ', '(', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'
                                            , 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u','v'
                                            , 'w', 'x', 'y', 'z', '+', '-' };
            public List<char> delim_8 = new List<char> { '\r', ',', '.', '\n', '\t', ' ', '!', '=', ')', '>', '<', '+', '-', '*', '/', '%' };
            public List<char> delim_9 = new List<char> { '\n', '\t', ' ', '.', ',', ')', '!', '=', '+', '-', '*', '/', '%', '>', '<'
                                                , 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'
                                            , 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u','v'
                                            , 'w', 'x', 'y', 'z', ']' };
            public List<char> delim_lower = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'
                                            , 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u','v'
                                            , 'w', 'x', 'y', 'z'};
            public List<char> rs_ender = new List<char> { '\r', '\n', '\t', ' ', '(', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'
                                            , 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u','v'
                                            , 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '"', ',', '.',
                                            '!', '=', ')', '>', '<', '+', '-', '*', '/', '%', ']'};
            public List<char> rs_one = new List<char> { '(', '"', ',', '.', '!', '=', ')', '>', '<', '+', '-', '*', '/', '%', ']' };
            public List<char> rs_repeat = new List<char> { '+', '-', '*', '/', '>', '<', '!', '=' };
        }
        public class Literals
        {
            public List<char> number = new List<char> { '~', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            public List<char> num = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        }
        public class LiteralsDelim
        {
            public List<string> delim_str = new List<string> { "nl", "tab", " ", ".", ",", ")", "=", "!" };
            public List<char> delim_dec = new List<char> { ' ', '\r', '\n', '\t', '.', ',', ')', '=', '!', '+', '-', '*', '/', '%', '>', '<' };
            public List<char> delim_num = new List<char> { ' ', '\r', '\n', '\t', '.', ',', ')', '=', '!', '+', '-', '*', '/', '%', '>', '<', ']', ':' };
        }
        // Identifiers
        public class Identifiers
        {
            public List<char> lowercase = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'
                                            , 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u','v'
                                            , 'w', 'x', 'y', 'z' };
            public List<char> allIn= new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'
                                            , 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u','v'
                                            , 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J'
                                                , 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V'
                                                , 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        }
        public class IdentifiersDelims
        {
            public List<char> delim_id = new List<char> { '\n', '\r', ' ', '.', ',', ')', '+', '-', '*', '/', '%', ':', '='
                                                , '!', '>', '<', '[', ']', '@', '(' };
        }
    }
}


                