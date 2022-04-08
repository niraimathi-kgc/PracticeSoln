using System;

namespace PracticeProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i, j;
            Console.Write("Enter value of stars to be printed: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (i = a; i >= 0; i--)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}