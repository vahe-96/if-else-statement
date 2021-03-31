using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            int c = int.Parse(Console.ReadLine());

            int temp;

            if (a < c)
            {
                temp = a;
                a = c;
                c = temp;
            }
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            if (b < c)
            {
                temp = b;
                b = c;
                c = temp;
            }

            Console.WriteLine("Sorted 3 numbers");
            Console.Write($"{a},{b},{c}");
        }
    }
}
