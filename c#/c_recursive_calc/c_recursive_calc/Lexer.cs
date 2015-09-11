using System;
using System.Collections.Generic;
using System.Linq;

namespace c_recursive_calc
{
    class Lexer : ILexer
    {
        public static string[] operators = new []{ "+", "-", "*", "/", "^", "(", ")"};
        public List<Token> Lex(string str)
        {
            List<Token> TokenList = new List<Token>();
            int iter = 0;
            while(true)
            {
                while (iter < str.Length && Char.IsWhiteSpace(str[iter]))
                    iter++;
                Token token = new Token();
                if (iter >= str.Length)
                {
                    TokenList.Add(token);
                    break;
                }
                else if (Char.IsNumber(str[iter]))
                {
                    while (iter < str.Length && Char.IsNumber(str[iter]))
                        token.Text += str[iter++];
                    token.Id = Token.TokenId.Number;
                }
                else
                {
                    token.Text += str[iter++];
                    if (operators.Contains(token.Text))
                        token.Id = Token.TokenId.Operator;
                    else
                        token.Id = Token.TokenId.Unknown;
                }
               TokenList.Add(token);
            }
            return TokenList;
        }
    }
}
