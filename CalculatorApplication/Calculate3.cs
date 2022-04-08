using System;

namespace CalculatorApplication
{
    class Calculate3
    {
        public void multi()
        {
            int i, j;
            Console.WriteLine("You've selected MULTIPLICATION \'*'");
            Console.WriteLine("Enter the value of the OPERANDS line by line: ");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The MULTIPLICATION value of " + i + " and " + j + " is " + (i * j));
        }
    }
}
