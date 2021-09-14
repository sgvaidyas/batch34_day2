using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day2
{
    class Program11
    {
        static void Main(string[] args)
        {
            int i;
            /*
            for (i=0;i<10;i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.WriteLine(i);
            }*/

            i = 0;
            while(i<5)
            {
                i++;
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
               
            }
        }
    }
}
