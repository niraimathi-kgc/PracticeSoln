using System;
using OopsConceptPractice;

namespace StaticClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, x, y, k;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("\tSIMPLE FRUITS AVAILABLE");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Press the specific functional button to BUY THE FRUITS ");
            Console.WriteLine("1 -> APPLE");
            Console.WriteLine("2 -> JACKFRUIT");
            Console.WriteLine("3 -> PINEAPPLE");
            Console.WriteLine("-------------------------------------------------------");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Static1.Apple();
                    break;
                case 2:
                    Static1.Jackfruit();
                    break;
                case 3:
                    Static1.Pineapple();
                    break;
                default:
                    Console.WriteLine("Enter a correct value...");
                    break;
            }
            Console.WriteLine("Enter the value of two operand");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            SealedClass sealedClass = new SealedClass();
            k = sealedClass.Add(x, y);
            Console.WriteLine(k);

         
            
        }
    }
}

