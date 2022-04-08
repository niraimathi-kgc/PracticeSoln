using System;
using System.Collections.Generic;
using System.Text;

namespace numberPatternPrograms
{
    class Pattern3
    {
        public void numPat3()
        {
            int i, j, k;
            Console.Write("3. Enter the value till the pattern should run: ");
            k = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=k;i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
