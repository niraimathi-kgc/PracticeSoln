using System;
using System.Collections.Generic;
using System.Text;

namespace patternPrograms
{
    class invertedHPyramid
    {
        public void invertedHalfPyramid()
        {
            int a, i, j;
            Console.Write("Enter value of stars to be printed: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (i = a; i >= 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
