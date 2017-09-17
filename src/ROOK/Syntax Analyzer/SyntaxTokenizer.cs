/*
 * SyntaxTokenizer.cs
 *
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 */

using System.IO;

using PerCederberg.Grammatica.Runtime;

namespace Syntax_Analyzer {

    /**
     * <remarks>A character stream tokenizer.</remarks>
     */
    public class SyntaxTokenizer : Tokenizer {

        /**
         * <summary>Creates a new tokenizer for the specified input
         * stream.</summary>
         *
         * <param name='input'>the input stream to read</param>
         *
         * <exception cref='ParserCreationException'>if the tokenizer
         * couldn't be initialized correctly</exception>
         */
        public SyntaxTokenizer(TextReader input)
            : base(input, false) {

            CreatePatterns();
        }

        /**
         * <summary>Initializes the tokenizer by creating all the token
         * patterns.</summary>
         *
         * <exception cref='ParserCreationException'>if the tokenizer
         * couldn't be initialized correctly</exception>
         */
        private void CreatePatterns() {
            TokenPattern  pattern;

            pattern = new TokenPattern((int) SyntaxConstants.PROGSTART,
                                       "PROGSTART",
                                       TokenPattern.PatternType.STRING,
                                       "!START");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.WRITE,
                                       "WRITE",
                                       TokenPattern.PatternType.STRING,
                                       "write");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.READ,
                                       "READ",
                                       TokenPattern.PatternType.STRING,
                                       "read");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.IF,
                                       "IF",
                                       TokenPattern.PatternType.STRING,
                                       "if");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.ELSE,
                                       "ELSE",
                                       TokenPattern.PatternType.STRING,
                                       "else");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.ELSEIF,
                                       "ELSEIF",
                                       TokenPattern.PatternType.STRING,
                                       "elseif");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.SWITCH,
                                       "SWITCH",
                                       TokenPattern.PatternType.STRING,
                                       "switch");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.CHOICE,
                                       "CHOICE",
                                       TokenPattern.PatternType.STRING,
                                       "choice");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.DEFAULT,
                                       "DEFAULT",
                                       TokenPattern.PatternType.STRING,
                                       "default");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.FOR,
                                       "FOR",
                                       TokenPattern.PatternType.STRING,
                                       "for");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.DO,
                                       "DO",
                                       TokenPattern.PatternType.STRING,
                                       "do");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.WHILE,
                                       "WHILE",
                                       TokenPattern.PatternType.STRING,
                                       "while");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.FILE,
                                       "FILE",
                                       TokenPattern.PatternType.STRING,
                                       "file");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.STOP,
                                       "STOP",
                                       TokenPattern.PatternType.STRING,
                                       "stop");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.JUMP,
                                       "JUMP",
                                       TokenPattern.PatternType.STRING,
                                       "jump");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.RETURN,
                                       "RETURN",
                                       TokenPattern.PatternType.STRING,
                                       "return");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.START,
                                       "START",
                                       TokenPattern.PatternType.STRING,
                                       "start");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.END,
                                       "END",
                                       TokenPattern.PatternType.STRING,
                                       "end");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.PROGEND,
                                       "PROGEND",
                                       TokenPattern.PatternType.STRING,
                                       "END!");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.AND,
                                       "AND",
                                       TokenPattern.PatternType.STRING,
                                       "and");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.OR,
                                       "OR",
                                       TokenPattern.PatternType.STRING,
                                       "or");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.FIXED,
                                       "FIXED",
                                       TokenPattern.PatternType.STRING,
                                       "fixed");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.ID,
                                       "ID",
                                       TokenPattern.PatternType.STRING,
                                       "id");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.STRING,
                                       "STRING",
                                       TokenPattern.PatternType.STRING,
                                       "string");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.BOOLEAN,
                                       "BOOLEAN",
                                       TokenPattern.PatternType.STRING,
                                       "boolean");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.NUMBER,
                                       "NUMBER",
                                       TokenPattern.PatternType.STRING,
                                       "number");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.DECIMAL,
                                       "DECIMAL",
                                       TokenPattern.PatternType.STRING,
                                       "decimal");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.NULL,
                                       "NULL",
                                       TokenPattern.PatternType.STRING,
                                       "null");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.NUMBERLIT,
                                       "NUMBERLIT",
                                       TokenPattern.PatternType.STRING,
                                       "numberlit");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.DECIMALLIT,
                                       "DECIMALLIT",
                                       TokenPattern.PatternType.STRING,
                                       "decimallit");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.STRINGLIT,
                                       "STRINGLIT",
                                       TokenPattern.PatternType.STRING,
                                       "stringlit");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.BOOLEANLIT,
                                       "BOOLEANLIT",
                                       TokenPattern.PatternType.STRING,
                                       "booleanlit");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.COL,
                                       "COL",
                                       TokenPattern.PatternType.STRING,
                                       ":");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.SEM,
                                       "SEM",
                                       TokenPattern.PatternType.STRING,
                                       ";");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.OP,
                                       "OP",
                                       TokenPattern.PatternType.STRING,
                                       "(");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.CP,
                                       "CP",
                                       TokenPattern.PatternType.STRING,
                                       ")");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.OB,
                                       "OB",
                                       TokenPattern.PatternType.STRING,
                                       "[");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.CB,
                                       "CB",
                                       TokenPattern.PatternType.STRING,
                                       "]");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.ADD,
                                       "ADD",
                                       TokenPattern.PatternType.STRING,
                                       "+");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.MIN,
                                       "MIN",
                                       TokenPattern.PatternType.STRING,
                                       "-");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.MUL,
                                       "MUL",
                                       TokenPattern.PatternType.STRING,
                                       "*");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.DIV,
                                       "DIV",
                                       TokenPattern.PatternType.STRING,
                                       "/");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.MOD,
                                       "MOD",
                                       TokenPattern.PatternType.STRING,
                                       "%");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.INC,
                                       "INC",
                                       TokenPattern.PatternType.STRING,
                                       "++");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.DEC,
                                       "DEC",
                                       TokenPattern.PatternType.STRING,
                                       "--");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.ISEQ,
                                       "ISEQ",
                                       TokenPattern.PatternType.STRING,
                                       "==");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.NOTEQ,
                                       "NOTEQ",
                                       TokenPattern.PatternType.STRING,
                                       "!=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.GREAT,
                                       "GREAT",
                                       TokenPattern.PatternType.STRING,
                                       ">");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.LESS,
                                       "LESS",
                                       TokenPattern.PatternType.STRING,
                                       "<");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.GEQ,
                                       "GEQ",
                                       TokenPattern.PatternType.STRING,
                                       ">=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.LEQ,
                                       "LEQ",
                                       TokenPattern.PatternType.STRING,
                                       "<=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.NOT,
                                       "NOT",
                                       TokenPattern.PatternType.STRING,
                                       "!");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.EQ,
                                       "EQ",
                                       TokenPattern.PatternType.STRING,
                                       "=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.PEQ,
                                       "PEQ",
                                       TokenPattern.PatternType.STRING,
                                       "+=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.MEQ,
                                       "MEQ",
                                       TokenPattern.PatternType.STRING,
                                       "-=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.MUEQ,
                                       "MUEQ",
                                       TokenPattern.PatternType.STRING,
                                       "*=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.DEQ,
                                       "DEQ",
                                       TokenPattern.PatternType.STRING,
                                       "/=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.COMMA,
                                       "COMMA",
                                       TokenPattern.PatternType.STRING,
                                       ",");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.AT,
                                       "AT",
                                       TokenPattern.PatternType.STRING,
                                       "@");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.OBR,
                                       "OBR",
                                       TokenPattern.PatternType.STRING,
                                       "{");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.CBR,
                                       "CBR",
                                       TokenPattern.PatternType.STRING,
                                       "}");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.WHITESPACE,
                                       "WHITESPACE",
                                       TokenPattern.PatternType.REGEXP,
                                       "[ \\t\\n\\r]+");
            pattern.Ignore = true;
            AddPattern(pattern);
        }
    }
}
