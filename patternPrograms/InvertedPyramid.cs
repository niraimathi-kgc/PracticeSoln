using System;
using System.Collections.Generic;
using System.Text;

namespace patternPrograms
{
    class InvertedPyramid
    {
        public void invertedPy1()
        {
            int i, j, a, k, l;
            Console.Write("Enter value of stars to be printed: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (i = a; i >= 1; i--)
            {
                for (j = a; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = i; k > 1; k--)
                {
                    Console.Write("*");
                }
                for (l = i; l >= 1; l--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        
    }
}