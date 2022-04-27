using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApplication
{
    public class Calculate5
    {
        public void modulo()
        {
            int i, j;
            Console.WriteLine("You've selected MODULO (REMAINDER OF DIVISION) \'%'");
            Console.WriteLine("Enter the value of the OPERANDS line by line: ");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The MODULO value of " + i + " and " + j + " is " + (i % j));
        }
    }
}
