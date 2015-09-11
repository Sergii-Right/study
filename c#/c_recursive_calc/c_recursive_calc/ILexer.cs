
using System.Collections.Generic;

namespace c_recursive_calc
{
    interface ILexer
    {
        List<Token> Lex(string str);
    }
}
