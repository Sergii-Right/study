using System;

namespace c_recursive_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            ILexer lexer = new Lexer();
            IParser parser = new Parser();

            while(true)
            {
                Console.Write("$ ");
                str = Console.ReadLine();
                if (str == "exit")
                    break;
                else
                {
                    try
                    {
                        Console.Write("  ");
                        Console.WriteLine(parser.Parse(lexer.Lex(str)).Eval().ToString());
                        Console.WriteLine();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    
                }

            }
        }
    }
}
