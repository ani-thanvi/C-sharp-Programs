using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int fact = 1;
            Console.WriteLine("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            for ( int i = 1; i <= x; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial : " + fact);
        }
    }
}
