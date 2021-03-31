using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number a for a*x*x + b*x + c = 0 quadratic equation");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b for a*x*x + b*x + c = 0 quadratic equation");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number c for a*x*x + b*x + c = 0 quadratic equation");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your quadratic equation is {a}*x*x + {b}*x + {c} = 0");

            double sq = b * b - 4 * a * c;
            double x, x1, x2;

            if (a == 0)
            {
                Console.WriteLine($"Your equation is not quadratic");
            }

            else
            {

                if (sq > 0)
                {
                    x1 = (-b + Math.Sqrt(sq)) / (2 * a);
                    x2 = (-b - Math.Sqrt(sq)) / (2 * a);

                    Console.WriteLine($"Two Real Solutions are {x1} and {x2}");
                }

                else if (sq < 0)
                {
                    sq = -sq;
                    x = -b / (2 * a);

                    Console.WriteLine($"Two Imaginary Solutions are {x} + {Math.Sqrt(sq) / (2 * a)}*i and {x} + {Math.Sqrt(sq) / (2 * a)}*i");
                }

                else
                {
                    x = (-b + Math.Sqrt(sq)) / (2 * a);
                    Console.WriteLine($"One Real Solution is {x}");
                }
            }
        }
    }
}
