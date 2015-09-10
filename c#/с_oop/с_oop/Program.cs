using System;

namespace с_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            var dog = new Dog();

            cat.Sound();
            dog.Sound();

            Console.WriteLine(Sum(10, 5));

            var solve = new Solve();
            solve.a = 10;
            solve.b = 11;
            solve.Solver();

        }

        public static double Sum(int a, int b)
        {
            return a + b;
        }
    }
}
