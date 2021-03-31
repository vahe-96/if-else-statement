using System;

namespace _5
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

            if (a >= b && a >= c)
            {
                Console.WriteLine($"maximum is {a}");
            }
            else if (b >= c)
            {
                Console.WriteLine($"maximum is {b}");
            }
            else
            {
                Console.WriteLine($"maximum is {c}");
            }
        }
    }
}
