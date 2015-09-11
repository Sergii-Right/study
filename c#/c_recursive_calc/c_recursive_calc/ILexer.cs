using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_recursive_calc
{
    interface ILexer
    {
        List<Token> Lex(string str);
    }
}
