using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConceptPractice
{
    public static class Static1
    {
        public static int a;
        public static void Apple()
        {
            Console.Write("How many apples do you want: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Apples you can take "+a);
        }
        public static void Jackfruit()
        {
            Console.Write("How many jackfruit do you want: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you can take " + a);
        }
        public static void Pineapple()
        {
            Console.Write("How many Pineapple do you want: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pineapple you can take " + a);
        }

    }
}
