using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day2
{
    class Program4
    {
        static void Main(string[] args)
        {
            int n, j , i;
            Console.WriteLine("Enter the val of n = ");
            n = Convert.ToInt32(Console.ReadLine());

            // for(i=1,j=n;i<=n; i++,j--)
           //    Console.WriteLine(i*j);
           for(i=1;i<=n;i++)
                Console.WriteLine(i*(n-i+1));
        }
    }
}
/*  
 *  
n=4

4 6 6 4
1*4
2*3
3*2
4*1
 */
