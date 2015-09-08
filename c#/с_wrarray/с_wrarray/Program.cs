using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace с_wrarray
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = Console.ReadLine();
            //Console.WriteLine(a);
            //Console.WriteLine(Console.ReadKey().Key);
            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //char[] arr = Console.ReadLine().ToCharArray();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //Console.WriteLine(arr[i]);
            //}
            char[] ar = Console.ReadLine().ToCharArray(0,2);
            Console.WriteLine("{0} {1}",ar[0],ar[1]);
        }
    }
}
