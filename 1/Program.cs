using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number a for a*x + b = 0 equation");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b for a*x + b = 0 equation");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your equation is {a}*x + {b} = 0");

            if (a != 0)
            {
                Console.WriteLine($"answer is x={-b / a}");
            }
            else if (b == 0)
            {
                Console.WriteLine("any x is solution for this equation");
            }

            else
            {
                Console.WriteLine("This equation has no solution");
            }
        }
    }
}
