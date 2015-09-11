
using System.Collections.Generic;

namespace c_recursive_calc
{
    interface IParser
    {
        INode Parse(List<Token> Tokens);
    }
}
