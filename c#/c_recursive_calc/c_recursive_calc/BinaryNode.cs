using System;

namespace c_recursive_calc
{
    class BinaryNode : INode
    {
        private INode left;
        private INode right;
        private char id;

        public BinaryNode(INode left, INode right, char id)
        {
            this.left = left;
            this.right = right;
            this.id = id;
        }
        public double Eval()
        {
            switch(id)
            {
                case '+': return left.Eval() + right.Eval();
                case '-': return left.Eval() - right.Eval();
                case '/': return left.Eval() / right.Eval();
                case '*': return left.Eval() * right.Eval();
                case '^': return Math.Pow(left.Eval(), right.Eval());
            }
            return 0;
        }
    }
}
