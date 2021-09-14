using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day2
{
    class Program12
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            Console.WriteLine("enter ele = ");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ARRAY ELENTS = ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
