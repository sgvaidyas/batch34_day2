using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day2
{
    class Program3
    {
        static void Main(string[] args)
        {
            int n, j=1,i;
            Console.WriteLine("Enter the val of n = ");
            n = Convert.ToInt32(Console.ReadLine());

            for(i=1;i<=n;i++)
            {
                j = j * i;
                Console.WriteLine(j);
            }
        }
    }
}
/*
 * n=4

1 2 6 24


i   j=j*i  
--------------------
1   1*1=1
2   1*2=2
3   2*3=6
4   6*4=24

    */