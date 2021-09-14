using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day2
{
    class Program6
    {
        static void Main(string[] args)
        {
            int n,i=2;
            Console.WriteLine("Enter the val of n = ");
            n = Convert.ToInt32(Console.ReadLine());
            while(i<=n/2)
            {
                if(n%i==0)
                {
                    Console.WriteLine(n +" not a prime num ");
                    break;
                }
                i++;
            }
            if(i>n/2)
                Console.WriteLine(n + " is a prime number");
        }
    }

}
/*   
 *   
 
     n=11

i  n%i         i++
------------------
2  11%2--> 1   3
3  11%3--> 2   4
4  11%4--> 3   5
5  11%5    1   6
6  11%6    5   7
7  11%7    4   8
8  11%8    3   9
9  11%9    2   10
10 11%10   1   11
*/
