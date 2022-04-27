using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApplication
{
    public class Calculate4
    {
        public void divide()
        {
            int i, j;
            Console.WriteLine("You've selected DIVISION \'/'");
            Console.WriteLine("Enter the value of the OPERANDS line by line: ");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The DIVISION value of " + i + " and " + j + " is " + (i / j));
        }
    }
}
