using System;
using System.Collections.Generic;
using System.Text;

namespace numberPatternPrograms
{
    class Pattern7
    {
        public void numPat7()
        {
            int i, j, k;
            Console.Write("7. Enter the value till the pattern should run: ");
            k = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= k; i++)
            {
                for (j = i; j <= k; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
