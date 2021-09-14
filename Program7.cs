using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day2
{
    class Program7
    {
        static void Main(string[] args)
        {
            int n, cnt=0;
            int rem = 0, sum = 0;
            Console.WriteLine("Enter the val of n = ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n!=0)
            {
                cnt++;
                rem = n % 10;
                sum += rem;
                n /= 10;
            }
            Console.WriteLine("Count of dig = "+cnt);
            Console.WriteLine("Sum of dig = " + sum);
        }
    }
}
/*   
 *   =================================
n     n!=0   cnt++  n=n/10
-------------------------------
65886   T     1      6588
6588    T     2      658
658     T     3      65
65      T     4      6
6       T     5      0
0       F
=====================================================

 n    rem    sum    n=n/10
-------------------------
658   8    0+8=8   65
65    5    8+5=13  6
6     6    13+6=19 0
0---->false
     */
