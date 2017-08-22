using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
