using System;
using System.Collections.Generic;
using System.Text;

namespace numberPatternPrograms
{
    class Pattern5
    {
        public void numPat5()
        {
            int i, j, k;
            Console.Write("5. Enter the value till the pattern should run: ");
            k = Convert.ToInt32(Console.ReadLine());
            for (i = k; i >= 1; i--)
            {
                for (j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
