namespace c_recursive_calc
{
    class ValueNode : INode
    {
        private double value;
        public ValueNode(double value)
        {
            this.value = value;
        }
        public double Eval()
        {
            return value;
        }
    }
}
