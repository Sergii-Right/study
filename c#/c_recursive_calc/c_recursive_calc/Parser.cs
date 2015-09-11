using System;
using System.Collections.Generic;

namespace c_recursive_calc
{
    class Parser : IParser
    {
        private Token token;
        private List<Token> tokens;
        private int iter;

        public INode Parse(List<Token> Tokens)
        {
            iter = 0;
            tokens = Tokens;
            token = Tokens[iter++];
            INode node = SumSub();
            if (token.Id != Token.TokenId.END)
                throw new Exception("There is an excess part of expression");

            return node;            
        }

        private bool Accept(string str)
        {
            if (token.Text == str)
            {
                token = tokens[iter++];
                return true;
            }
            else
                return false;
        }

        public INode SumSub()
        {
            INode node = MulDiv();
            while (true)
            {
                if (Accept("+"))
                    node = new BinaryNode(node, MulDiv(), '+');
                else if (Accept("-"))
                    node = new BinaryNode(node, MulDiv(), '-');
                else
                    break;
            }
            return node;
        }

        public INode MulDiv()
        {
            INode node = Power();
            while (true)
            {
                if (Accept("*"))
                    node = new BinaryNode(node, Power(), '*');
                else if (Accept("/"))
                    node = new BinaryNode(node, Power(), '/');
                else
                    break;
            }
            return node;
        }

        public INode Power()
        {
            INode node = Unary();
            while (true)
            {
                if (Accept("^"))
                    node = new BinaryNode(node, Unary(), '^');
                else
                    break;
            }
            return node;
        }

        public INode Unary()
        {
            INode node = null;
            if (Accept("+"))
                node = Term();
            else if (Accept("-"))
                node = new BinaryNode(new ValueNode(0), Term(), '-');
            else
                node = Term();
            return node;
        }

        public INode Term()
        {
            INode node = null;
            if (token.Id == Token.TokenId.Number)
            {
                node = new ValueNode(double.Parse(token.Text));
                token = tokens[iter++];
            }
            else if (Accept("("))
            {
                node = SumSub();
                if (!Accept(")"))
                    throw new Exception("Unmatched parentheses");
            }
            else if (token.Id == Token.TokenId.Unknown)
                throw new Exception("unknown token " + token.Text);
            else if (token.Id == Token.TokenId.END)
                throw new Exception("Unexpected end of expression");
            else
                throw new Exception("Unexpected token " + token.Text);
            return node;
        }
    }
}
