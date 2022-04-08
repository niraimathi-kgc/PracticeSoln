using System;
using System.Collections.Generic;
using System.Text;

namespace numberPatternPrograms
{
    class Pattern2
    {
        public void numPat2()
        {
            int i, j, k;
            Console.Write("2. Enter the value till the pattern should run: ");
            k = Convert.ToInt32(Console.ReadLine());
            for(i = k; i>=1;i--)
            {
                for(j = 1; j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
