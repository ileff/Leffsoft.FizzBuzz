using System;
using Leffsoft.FizzBuzz;

namespace TestApp
{
    class Program
    {
        // ian was here
        // cloud ian was here too

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzz.Value(i));
            }

            Console.ReadLine();
        }
    }
}
