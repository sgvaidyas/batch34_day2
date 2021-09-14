using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day2
{
    class Program5
    {
        static void Main(string[] args)
        {
            int n, j, i;
            Console.WriteLine("Enter the val of n = ");
            n = Convert.ToInt32(Console.ReadLine());

            for(i=1;i<=n;i++)
            {
                for(j=1;j<=n;j++)
                {
                    if(i==1 || i==n || j==1 ||j==n || i==j || i+j == n+1)
                        Console.Write("1");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
