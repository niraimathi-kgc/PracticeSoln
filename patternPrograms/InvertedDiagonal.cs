using System;
using System.Collections.Generic;
using System.Text;

namespace patternPrograms
{
    class InvertedDiagonal
    {
        public void invertedDiagonalPyramid()
        {
            int i, j, k;
            int a;
            Console.Write("Enter value of stars to be printed: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (i = a; i >= 1; i--)
            {
                for (j = i; j <= a; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
