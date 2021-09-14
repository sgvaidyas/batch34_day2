using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day2
{
    class Program13
    {
        static void add()
        {
            int a, b;
            Console.WriteLine("Enter the val of a = " );
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the val of b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sum = " + (a+b));
        }

        static void sub(int a,int b)
        {
            Console.WriteLine("diffrence = " +(a-b));
        }
        static int mul(int a,int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            //function without param and without returning any val
            add();
            int a, b;
            Console.WriteLine("Enter the val of a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the val of b = ");
            b = Convert.ToInt32(Console.ReadLine());
            //function with parameters but no return statement
            sub(a, b);
            //function with parameter and return
            int res = mul(a, b);
            Console.WriteLine("the product = " + res);
            Console.WriteLine("the product = " + mul(7,8));

        }
    }
}
