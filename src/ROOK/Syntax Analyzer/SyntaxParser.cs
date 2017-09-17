/*
 * SyntaxParser.cs
 *
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 */

using System.IO;

using PerCederberg.Grammatica.Runtime;

namespace Syntax_Analyzer {

    /**
     * <remarks>A token stream parser.</remarks>
     */
    public class SyntaxParser : RecursiveDescentParser {

        /**
         * <summary>An enumeration with the generated production node
         * identity constants.</summary>
         */
        private enum SynteticPatterns {
        }

        /**
         * <summary>Creates a new parser with a default analyzer.</summary>
         *
         * <param name='input'>the input stream to read from</param>
         *
         * <exception cref='ParserCreationException'>if the parser
         * couldn't be initialized correctly</exception>
         */
        public SyntaxParser(TextReader input)
            : base(input) {

            CreatePatterns();
        }

        /**
         * <summary>Creates a new parser.</summary>
         *
         * <param name='input'>the input stream to read from</param>
         *
         * <param name='analyzer'>the analyzer to parse with</param>
         *
         * <exception cref='ParserCreationException'>if the parser
         * couldn't be initialized correctly</exception>
         */
        public SyntaxParser(TextReader input, SyntaxAnalyzer analyzer)
            : base(input, analyzer) {

            CreatePatterns();
        }

        /**
         * <summary>Creates a new tokenizer for this parser. Can be overridden
         * by a subclass to provide a custom implementation.</summary>
         *
         * <param name='input'>the input stream to read from</param>
         *
         * <returns>the tokenizer created</returns>
         *
         * <exception cref='ParserCreationException'>if the tokenizer
         * couldn't be initialized correctly</exception>
         */
        protected override Tokenizer NewTokenizer(TextReader input) {
            return new SyntaxTokenizer(input);
        }

        /**
         * <summary>Initializes the parser by creating all the production
         * patterns.</summary>
         *
         * <exception cref='ParserCreationException'>if the parser
         * couldn't be initialized correctly</exception>
         */
        private void CreatePatterns() {
            ProductionPattern             pattern;
            ProductionPatternAlternative  alt;

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_PROGRAM,
                                            "Prod_program");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_GLOBAL, 0, 1);
            alt.AddToken((int) SyntaxConstants.PROGSTART, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
            alt.AddToken((int) SyntaxConstants.PROGEND, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_GLOBAL,
                                            "Prod_global");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_GLOBAL_CHOICE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_GLOBAL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_GLOBAL_CHOICE,
                                            "Prod_global_choice");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_FIXED_DEC, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VARDEC, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_FILE, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_FUNCT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FIXED_DEC,
                                            "Prod_fixed_dec");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.FIXED, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FDATA_TYPE, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FDATA_TYPE,
                                            "Prod_fdata_type");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NUMBER, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FVALUES_NUM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DECIMAL, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FVALUES_DEC, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.STRING, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FVALUES_STR, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.BOOLEAN, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FVALUES_BOOL, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FVALUES_NUM,
                                            "Prod_fvalues_num");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.NUMBERLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FMORE_NUM, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FMORE_NUM,
                                            "Prod_fmore_num");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FVALUES_NUM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FVALUES_DEC,
                                            "Prod_fvalues_dec");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.DECIMALLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FMORE_DEC, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FMORE_DEC,
                                            "Prod_fmore_dec");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FVALUES_DEC, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FVALUES_STR,
                                            "Prod_fvalues_str");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.STRINGLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FMORE_STR, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FMORE_STR,
                                            "Prod_fmore_str");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FVALUES_STR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FVALUES_BOOL,
                                            "Prod_fvalues_bool");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.BOOLEANLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FMORE_BOOL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FMORE_BOOL,
                                            "Prod_fmore_bool");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FVALUES_BOOL, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DTYPE,
                                            "Prod_dtype");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NUMBER, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DECIMAL, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.STRING, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.BOOLEAN, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_VARDEC,
                                            "Prod_vardec");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DATA_TYPE, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DATA_TYPE,
                                            "Prod_data_type");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NUMBER, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUES_NUM, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DECIMAL, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUES_DEC, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.STRING, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUES_STR, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.BOOLEAN, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUES_BOOL, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_VALUES_NUM,
                                            "Prod_values_num");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.NUMBERLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_NUM, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_NUM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MORE_NUM,
                                            "Prod_more_num");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUES_NUM, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_VALUES_DEC,
                                            "Prod_values_dec");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.DECIMALLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_DEC, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_DEC, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MORE_DEC,
                                            "Prod_more_dec");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUES_DEC, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_VALUES_STR,
                                            "Prod_values_str");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.STRINGLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_STR, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_STR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MORE_STR,
                                            "Prod_more_str");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUES_STR, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_VALUES_BOOL,
                                            "Prod_values_bool");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.BOOLEANLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_BOOL, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_BOOL, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MORE_BOOL,
                                            "Prod_more_bool");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUES_BOOL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FILE,
                                            "Prod_file");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.FILE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.START, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FILE_ELEM, 1, 1);
            alt.AddToken((int) SyntaxConstants.END, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FILE_ID, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FILE_ELEM,
                                            "Prod_file_elem");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FILE_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FILE_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FILE_TAIL,
                                            "Prod_file_tail");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_FILE_ELEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FILE_ID,
                                            "Prod_file_id");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FILE_ID_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FILE_ID_TAIL,
                                            "Prod_file_id_tail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FILE_ID_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FUNCT,
                                            "Prod_funct");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NUMBER, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAM, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.START, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
            alt.AddToken((int) SyntaxConstants.RETURN, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RETURN_NUM, 1, 1);
            alt.AddToken((int) SyntaxConstants.END, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DECIMAL, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAM, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.START, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
            alt.AddToken((int) SyntaxConstants.RETURN, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RETURN_DEC, 1, 1);
            alt.AddToken((int) SyntaxConstants.END, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.STRING, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAM, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.START, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
            alt.AddToken((int) SyntaxConstants.RETURN, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RETURN_STR, 1, 1);
            alt.AddToken((int) SyntaxConstants.END, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.BOOLEAN, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAM, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.START, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
            alt.AddToken((int) SyntaxConstants.RETURN, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RETURN_BOOL, 1, 1);
            alt.AddToken((int) SyntaxConstants.END, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NULL, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAM, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.START, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
            alt.AddToken((int) SyntaxConstants.END, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_PARAM,
                                            "Prod_param");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAM_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_PARAM_TAIL,
                                            "Prod_param_tail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAM_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_RETURN_NUM,
                                            "Prod_returnNum");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NUMBERLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RETURN_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_RETURN_DEC,
                                            "Prod_returnDec");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DECIMALLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RETURN_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_RETURN_STR,
                                            "Prod_returnStr");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.STRINGLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RETURN_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_RETURN_BOOL,
                                            "Prod_returnBool");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.BOOLEANLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RETURN_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_RETURN_TAIL,
                                            "Prod_returnTail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FUNCT_PARAM, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_ELEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FUNCT_PARAM,
                                            "Prod_funct_param");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FUNCT_PARAM_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FUNCT_PARAM_TAIL,
                                            "Prod_funct_paramTail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FUNCT_PARAM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_VALUE,
                                            "Prod_value");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUES, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_ELEM_TAIL, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_VALUES,
                                            "Prod_values");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NUMBERLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DECIMALLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.STRINGLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.BOOLEANLIT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ELEM,
                                            "Prod_elem");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.AT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ELEM_TAIL, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ELEM_TAIL,
                                            "Prod_elem_tail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ELEM, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRAY,
                                            "Prod_array");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_NUMB_ARRAY, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DEC_ARRAY, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_STR_ARRAY, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_BOOL_ARRAY, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRAY_CHOICE,
                                            "Prod_array_choice");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_OPS, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NUMBERLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_OPS, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_NUMB_ARRAY,
                                            "Prod_numb_array");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NUMBER, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_NUMBER_ARRAY, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_NUMBER_ARRAY, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_NUMBER_ARRAY,
                                            "Prod_number_array");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY_CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_NUMBER_ARRAY_TAIL, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_NUMBER_ARRAY_TAIL,
                                            "Prod_number_arrayTail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.NUMBERLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_NUMBER, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY_CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_NUMBER_ARRAY2TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MORE_NUMBER_ARRAY,
                                            "Prod_more_numberArray");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_NUMBER_ARRAY, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_NUMBER_ARRAY, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MORE_NUMBER,
                                            "Prod_moreNumber");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.NUMBERLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_NUMBER, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_NUMBER_ARRAY2TAIL,
                                            "Prod_number_array2Tail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_NUMBER_ARRAY2VAL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_NUMBER_ARRAY2VAL_TAIL, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_NUMBER_ARRAY2VAL,
                                            "Prod_number_array2Val");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.NUMBERLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_NUMBER, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_NUMBER_ARRAY2VAL_TAIL,
                                            "Prod_number_array2Val_tail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_NUMBER_ARRAY2VAL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_NUMBER_ARRAY2VAL_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DEC_ARRAY,
                                            "Prod_dec_array");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DECIMAL, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DECIMAL_ARRAY, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_DECIMAL_ARRAY, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DECIMAL_ARRAY,
                                            "Prod_decimal_array");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY_CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DECIMAL_ARRAY_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DECIMAL_ARRAY_TAIL,
                                            "Prod_decimal_arrayTail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.DECIMALLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_DECIMAL, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY_CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DECIMAL_ARRAY2TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MORE_DECIMAL_ARRAY,
                                            "Prod_more_decimalArray");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DECIMAL_ARRAY, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_DECIMAL_ARRAY, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MORE_DECIMAL,
                                            "Prod_moreDecimal");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.DECIMALLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_DECIMAL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DECIMAL_ARRAY2TAIL,
                                            "Prod_decimal_array2Tail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DECIMAL_ARRAY2VAL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DECIMAL_ARRAY2VAL_TAIL, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DECIMAL_ARRAY2VAL,
                                            "Prod_decimal_array2Val");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.DECIMALLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_DECIMAL, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DECIMAL_ARRAY2VAL_TAIL,
                                            "Prod_decimal_array2Val_tail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DECIMAL_ARRAY2VAL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DECIMAL_ARRAY2VAL_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_STR_ARRAY,
                                            "Prod_str_array");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.STRING, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STRING_ARRAY, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_STRING_ARRAY, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_STRING_ARRAY,
                                            "Prod_string_array");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY_CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STRING_ARRAY_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_STRING_ARRAY_TAIL,
                                            "Prod_string_arrayTail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.STRINGLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_STRING, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY_CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY_CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STRING_ARRAY2TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MORE_STRING_ARRAY,
                                            "Prod_more_stringArray");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STRING_ARRAY, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_STRING_ARRAY, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MORE_STRING,
                                            "Prod_moreString");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.STRINGLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_STRING, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_STRING_ARRAY2TAIL,
                                            "Prod_string_array2Tail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STRING_ARRAY2VAL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STRING_ARRAY2VAL_TAIL, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_STRING_ARRAY2VAL,
                                            "Prod_string_array2Val");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.STRINGLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_STRING, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_STRING_ARRAY2VAL_TAIL,
                                            "Prod_string_array2Val_tail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STRING_ARRAY2VAL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STRING_ARRAY2VAL_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_BOOL_ARRAY,
                                            "Prod_bool_array");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.BOOLEAN, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BOOLEAN_ARRAY, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_BOOLEAN_ARRAY, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_BOOLEAN_ARRAY,
                                            "Prod_boolean_array");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY_CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BOOLEAN_ARRAY_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_BOOLEAN_ARRAY_TAIL,
                                            "Prod_boolean_arrayTail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.DECIMALLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_BOOLEAN, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY_CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY_CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BOOLEAN_ARRAY2TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MORE_BOOLEAN_ARRAY,
                                            "Prod_more_booleanArray");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BOOLEAN_ARRAY, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_BOOLEAN_ARRAY, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MORE_BOOLEAN,
                                            "Prod_moreBoolean");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.BOOLEANLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_BOOLEAN, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_BOOLEAN_ARRAY2TAIL,
                                            "Prod_boolean_array2Tail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BOOLEAN_ARRAY2VAL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BOOLEAN_ARRAY2VAL_TAIL, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_BOOLEAN_ARRAY2VAL,
                                            "Prod_boolean_array2Val");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.BOOLEANLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_BOOLEAN, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_BOOLEAN_ARRAY2VAL_TAIL,
                                            "Prod_boolean_array2Val_tail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BOOLEAN_ARRAY2VAL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BOOLEAN_ARRAY2VAL_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_STATEMENT,
                                            "Prod_statement");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_FUNCTION, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FUNCTION,
                                            "Prod_function");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VARDEC, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.FILE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_INC_DEC, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_ID_FUNC, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_IO_STATEMENT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_IF_STATEMENT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_SWITCH, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_LOOPING, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_IO_STATEMENT,
                                            "Prod_io_statement");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WRITE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_OUTPUT, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.READ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_IDS_TAIL, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_OUTPUT,
                                            "Prod_output");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.STRINGLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_OUTPUT_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_IDS_TAIL, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_OUTPUT_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_OUTPUT_TAIL,
                                            "Prod_output_tail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_OUTPUT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_IDS_TAIL,
                                            "Prod_ids_tail");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_ID_CHOICES, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ID_CHOICES,
                                            "Prod_id_choices");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_ELEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY_CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MORE_ARRAY, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MORE_ARRAY,
                                            "Prod_more_array");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY_CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_INC_DEC,
                                            "Prod_inc_dec");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INC_DEC_OP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_INC_DEC_OP, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_INC_DEC_OP,
                                            "Prod_inc_decOp");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.INC, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DEC, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ID_FUNC,
                                            "Prod_id_func");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_IDS_TAIL, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ID_FUNC_TAIL, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ID_FUNC_TAIL,
                                            "Prod_id_funcTail");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_ASS_OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ASS_OP_VALUES, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FUNCT_PARAM, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ASS_OP,
                                            "Prod_ass_op");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PEQ, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.MEQ, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.MUEQ, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DEQ, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ASS_VALUES,
                                            "Prod_ass_values");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.BOOLEANLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.STRINGLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_ASS_OP_VALUES, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ASS_OP_VALUES,
                                            "Prod_ass_opValues");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_IF_STATEMENT,
                                            "Prod_if_statement");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.IF, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CONDITION, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATES, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ELSEIF_STATEMENT, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ELSE_STATEMENT, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONDITION,
                                            "Prod_condition");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_CONDITIONAL, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_NOT, 0, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CONDITIONAL, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_LOGOP_END, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONDITIONAL,
                                            "Prod_conditional");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_COMPARES, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RELOP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_COMPARES, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_COMPARES,
                                            "Prod_compares");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ID_COMPARES, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUES, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ID_COMPARES,
                                            "Prod_id_compares");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_IDS_TAIL, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FUNCT_PARAM, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_RELOP,
                                            "Prod_relop");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ISEQ, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NOTEQ, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.GREAT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.LESS, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.GEQ, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.LEQ, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_NOT,
                                            "Prod_not");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NOT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_LOGOP_END,
                                            "Prod_logop_end");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_LOGOP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_LOGOP_MORE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_LOGOP_END, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_LOGOP,
                                            "Prod_logop");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.AND, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_LOGOP_MORE,
                                            "Prod_logop_more");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_NOT, 0, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CONDITIONAL, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.BOOLEANLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_LOGOP_END, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_STATES,
                                            "Prod_states");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_FUNCTION, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CONTROL, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATES_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_STATES_TAIL,
                                            "Prod_statesTail");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_STATES, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONTROL,
                                            "Prod_control");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.JUMP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.STOP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ELSEIF_STATEMENT,
                                            "Prod_elseif_statement");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ELSEIF, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CONDITION, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.START, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATES, 1, 1);
            alt.AddToken((int) SyntaxConstants.END, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ELSEIF_STATEMENT, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ELSE_STATEMENT,
                                            "Prod_else_statement");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ELSE, 1, 1);
            alt.AddToken((int) SyntaxConstants.START, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATES, 1, 1);
            alt.AddToken((int) SyntaxConstants.END, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DIGIT,
                                            "Prod_digit");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NUMBERLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DECIMALLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ID_COMPARES, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DIGIT_TAIL,
                                            "Prod_digit_tail");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_MATHOP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DIGIT_OP,
                                            "Prod_digit_op");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATHOP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT_OP, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT_OP_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DIGIT_OP_TAIL,
                                            "Prod_digit_opTail");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_MATHOP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT_OP, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_SWITCH,
                                            "Prod_switch");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SWITCH, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.START, 1, 1);
            alt.AddToken((int) SyntaxConstants.CHOICE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CHOICES, 1, 1);
            alt.AddToken((int) SyntaxConstants.END, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CHOICES,
                                            "Prod_choices");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_CHOICE_NUM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_CHOICE_STR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CHOICE_NUM,
                                            "Prod_choice_num");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NUMBERLIT, 1, 1);
            alt.AddToken((int) SyntaxConstants.COL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
            alt.AddToken((int) SyntaxConstants.STOP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CHOICE_NUMTAIL, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DEFAULT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CHOICE_NUMTAIL,
                                            "Prod_choice_numtail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.NUMBERLIT, 1, 1);
            alt.AddToken((int) SyntaxConstants.COL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
            alt.AddToken((int) SyntaxConstants.STOP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CHOICE_NUMTAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CHOICE_STR,
                                            "Prod_choice_str");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.STRINGLIT, 1, 1);
            alt.AddToken((int) SyntaxConstants.COL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
            alt.AddToken((int) SyntaxConstants.STOP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CHOICE_STRTAIL, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DEFAULT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CHOICE_STRTAIL,
                                            "Prod_choice_strtail");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.STRINGLIT, 1, 1);
            alt.AddToken((int) SyntaxConstants.COL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
            alt.AddToken((int) SyntaxConstants.STOP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CHOICE_STRTAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DEFAULT,
                                            "Prod_default");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DEFAULT, 1, 1);
            alt.AddToken((int) SyntaxConstants.COL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
            alt.AddToken((int) SyntaxConstants.STOP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_LOOPING,
                                            "Prod_looping");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.FOR, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT, 0, 1);
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_COND_FOR, 0, 1);
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FOR_INC, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.START, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATES, 1, 1);
            alt.AddToken((int) SyntaxConstants.END, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WHILE, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CONDITION, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.START, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATES, 1, 1);
            alt.AddToken((int) SyntaxConstants.END, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DO, 1, 1);
            alt.AddToken((int) SyntaxConstants.START, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATES, 1, 1);
            alt.AddToken((int) SyntaxConstants.END, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddToken((int) SyntaxConstants.WHILE, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CONDITION, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FOR_DEC,
                                            "Prod_for_dec");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NUMBER, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_INIT,
                                            "Prod_init");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_FOR_DEC, 0, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FOR_INIT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FOR_INIT,
                                            "Prod_for_init");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NUMBERLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_OPS, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_OPS, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_COND_FOR,
                                            "Prod_cond_for");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_FOR_INIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RELOP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FOR_INIT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FOR_INC,
                                            "Prod_for_inc");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INC_DEC_OP, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_INC_DEC_OP, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_OPS,
                                            "Prod_ops");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_MATHOP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY_CHOICE, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MATHOP,
                                            "Prod_mathop");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ADD, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.MIN, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.MUL, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DIV, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.MOD, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);
        }
    }
}
