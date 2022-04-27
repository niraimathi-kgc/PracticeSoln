using System;

namespace CalculatorApplication
{
   public class Calculate2
    {
        public void sub()
        {
            int i, j;
            Console.WriteLine("You've selected SUBTRACTION \'-'");
            Console.WriteLine("Enter the value of the OPERANDS line by line: ");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The SUBTRACTION value of " + i + " and " + j + " is " + (i - j));
        }
    }
}
