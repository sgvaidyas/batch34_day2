using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int n,j=1;
            Console.WriteLine("Enter the val of n = ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<n;i++)
            {
                Console.WriteLine(j);
                j = j * 2;
            }
        }
    }
}
