using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Enter number");
            while (s == 0)
            {
                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    if (a % 2 == 1 || a % 3 == 0)
                    {
                        Console.WriteLine($"Number multiplied by 2 is { 2 * a}");
                    }
                    else
                    {
                        Console.WriteLine($"The same number-{a}");
                    }
                    s = 1;
                }
                else
                {
                    Console.WriteLine("Entered expression is wrong, Please enter again");
                }
            }
        }
    }
}
