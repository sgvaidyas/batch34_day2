using System;

namespace Batch34_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
                int n, i, j;
                Console.WriteLine("Enter the val of n = ");
                n = Convert.ToInt32(Console.ReadLine());

                for ( i = 1, j = 1; i <= n; i++, j += 3)
                    Console.WriteLine(j);            
        }
    }
}
/*
 * n=5

1  4  7  10  13

for(i=1,j=1;i<=n;i++,j+=3)
	cw(j)
	
i   i<=n     print j   j=j+3    i++
------------------------------------------
1   1<=5     1          4        2
2   2<=5     4          7        3
3   3<=5     7         10        4
4   4<=5    10         13        5
5   5<=5    13         16        6
6   6<=5  false

    */