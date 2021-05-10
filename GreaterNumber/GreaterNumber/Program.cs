using System;

namespace GreaterNumber
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter two Number x & y");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if(x>y)
            {
                Console.WriteLine("Biggest Number is " + x);
            }
            else
            {
                Console.WriteLine("Biggest Number is " + y);
            }
        }
    }
}
