using System;
using System.Collections.Generic;
using System.Text;

namespace numberPatternPrograms
{
    class Pattern6
    {
        public void numPat6()
        {
            int i, j, k;
            Console.Write("6. Enter the value till the pattern should run: ");
            k = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= k; i++)
            {
                for (j = k; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
