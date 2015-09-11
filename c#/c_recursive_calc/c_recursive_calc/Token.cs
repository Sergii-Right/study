
namespace c_recursive_calc
{
    class Token
    {
        public enum TokenId { Number, Operator, Unknown, END }

        public string Text { get; set; }
        public TokenId Id { get; set; }
        
        public Token()
        {
            Text = "";
            Id = TokenId.END;
        }
    }
}
