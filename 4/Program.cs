using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double b = Double.Parse(Console.ReadLine());

            if (a <= b)
            {
                Console.WriteLine($"minimum is {a}");
            }
            else
            {
                Console.WriteLine($"minimum is {b}");
            }
        }
    }
}
