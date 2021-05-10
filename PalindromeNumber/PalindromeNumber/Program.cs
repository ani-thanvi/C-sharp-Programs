using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sum = 0, x1, t;
            Console.WriteLine("Enter the Numebr : ");
            x = Convert.ToInt32(Console.ReadLine());
            x1 = x;
            while(x!=0)
            {
                t = x % 10;
                sum = (sum * 10) + t;
                x = x / 10;

            }
            if ( x1 == sum )
            {
                Console.WriteLine("A Palindrome number");
            }
            else
            {
                Console.WriteLine("Not a Palindrome Number");
            }
        }
    }
}
