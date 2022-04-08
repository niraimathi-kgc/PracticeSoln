using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApplication
{
    class Calculate1
    {
        public void sum()
        {
            int i, j;
            Console.WriteLine("You've selected ADDITION \'+'");
            Console.WriteLine("Enter the value of the OPERANDS line by line: ");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The ADDITION value of "+i+" and "+j+" is "+ (i+j));
        }
    }
}
