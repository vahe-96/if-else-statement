using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            double c = Double.Parse(Console.ReadLine());

            if (a <= b && a <= c)
            {
                Console.WriteLine($"minimum is {a}");
            }
            else if (b <= c)
            {
                Console.WriteLine($"minimum is {b}");
            }
            else
            {
                Console.WriteLine($"minimum is {c}");
            }
        }
    }
}
