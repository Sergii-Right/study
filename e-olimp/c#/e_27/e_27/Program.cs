using System;

namespace e_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "0", str = Convert.ToString(Convert.ToInt32(Console.ReadLine()),2);
            int index = 0, length = str.Length;
            str = str + str + str;
            foreach(char c in str)
            {
                if (c == '1' && (length - index > 0))
                    if (Convert.ToInt32(str.Substring(index, length), 2) > Convert.ToInt32(str1, 2))
                        str1 = str.Substring(index, length);
                index++;       
            }
            Console.WriteLine(Convert.ToInt32(str1,2));
        }
    }
}
