using System;
using System.Collections.Generic;
using System.Text;

namespace patternPrograms
{
    class Pyramid
    {
        public void Pyramid1()
        {
            int i, j, k, a, l;
            Console.Write("Enter value of stars to be printed: ");
            a = Convert.ToInt32(Console.ReadLine());
            for(i = 1; i<=a; i++)
            {
                for(j = i;j<=a;j++)
                {
                    Console.Write(" ");
                }
                for(k = 1;k<i;k++)
                {
                    Console.Write("*");
                }
                for(l=1;l<=i;l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
