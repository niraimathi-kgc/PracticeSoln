using System;
using System.Collections.Generic;
using System.Text;

namespace patternPrograms
{
    class halfPyramid
    {
        public void halfPyramid1()
        {
            int a, i, j;
            Console.Write("Enter value of stars to be printed: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= a; i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            Console.ReadKey();
            Console.Read();
        }
    }
}
