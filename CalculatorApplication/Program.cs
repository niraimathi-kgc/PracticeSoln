using System;

namespace CalculatorApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, i;
            i = 0;
            Calculate1 call1 = new Calculate1();
            Calculate2 call2 = new Calculate2();
            Calculate3 call3 = new Calculate3();
            Calculate4 call4 = new Calculate4();
            Calculate5 call5 = new Calculate5();
            do
            {


                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("\tSIMPLE CALCULATOR USING C#");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Press the specific functional button to use calculator ");
                Console.WriteLine("1 -> ADDITION OF THE OPERAND");
                Console.WriteLine("2 -> SUBTRACTION OF THE OPERAND");
                Console.WriteLine("3 -> MULTIPLICATION OF THE OPERAND");
                Console.WriteLine("4 -> DIVISION OF THE OPERAND");
                Console.WriteLine("5 -> TO FIND THE REMAINDER OF THE OPERAND");
                Console.WriteLine("-------------------------------------------------------");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        call1.sum();
                        break;
                    case 2:
                        call2.sub();
                        break;
                    case 3:
                        call3.multi();
                        break;
                    case 4:
                        call4.divide();
                        break;
                    case 5:
                        call5.modulo();
                        break;
                    default:
                        Console.WriteLine("ENTER A VALID NUMBER TO ACCESS THE CALCULATOR...");
                        break;
                }
                Console.Write("To Continue... Press 1 or press eny key to exit: ");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            } while (i == 1);

        }
    }
}
