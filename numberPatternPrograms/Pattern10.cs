using System;
using System.Collections.Generic;
using System.Text;

namespace numberPatternPrograms
{
    class Pattern10
    {
        public void numPat10()
        {
            int i, j, k;
            Console.Write("10. Enter the value till the pattern should run: ");
            k = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= k; i++)
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
