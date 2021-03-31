using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Enter number");
            while (s == 0)
            {
                if (int.TryParse(Console.ReadLine(), out int a) && a >= 0)
                {
                    if (a % 2 == 0)
                    {
                        Console.WriteLine($"{a} is an even number");
                    }
                    else
                    {
                        Console.WriteLine($"{a} is an odd number");
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
