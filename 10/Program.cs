using System;

namespace _10
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
                    if (a % 5 == 0)
                    {
                        Console.WriteLine($"{a} is divisible by 5 without a remainder");
                    }
                    else
                    {
                        Console.WriteLine($"{a} is not divisible by 5 without a remainder");
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
