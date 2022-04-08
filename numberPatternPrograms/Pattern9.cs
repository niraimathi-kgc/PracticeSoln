using System;
using System.Collections.Generic;
using System.Text;

namespace numberPatternPrograms
{
    class Pattern9
    {
        public void numPat9()
        {
            int i, j, k;
            Console.Write("9. Enter the value till the pattern should run: ");
            k = Convert.ToInt32(Console.ReadLine());
            for(i = k; i>= 1; i--)
            {
                for(j = i; j<= k; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
