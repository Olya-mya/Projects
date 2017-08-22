using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc.Add(1,2);
            Console.WriteLine(DateTime.Now);
            Console.ReadKey();
        }
    }

    class Calc 
    {
        public static void Add (int x, int y) 
        {
            int z = x+y;
            Console.WriteLine($"Summ {x}+{y}={z}");
        }
    }
}
