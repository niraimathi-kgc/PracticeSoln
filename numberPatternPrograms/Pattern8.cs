using System;
using System.Collections.Generic;
using System.Text;

namespace numberPatternPrograms
{
    class Pattern8
    {
        public void numPat8()
        {
            int i, j, k;
            Console.Write("8. Enter the value till the pattern should run: ");
            k = Convert.ToInt32(Console.ReadLine());
            for (i = k; i >= 1; i--)
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
