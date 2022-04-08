using System;
using System.Collections.Generic;
using System.Text;

namespace numberPatternPrograms
{
    class Pattern4
    {
        public void numPat4()
        {
            int i, j, k;
            Console.Write("4. Enter the value till the pattern should run: ");
            k = Convert.ToInt32(Console.ReadLine());
            for (i = k; i >= 1; i--)
            {
                for (j = k; j >= i; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
