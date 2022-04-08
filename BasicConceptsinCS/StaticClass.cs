using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConceptsinCS
{
     public static class StaticClass
    {
       public static void StaticMethod()
        {
            int a = 1;
            Abs3 abs = new Abs3();
            do
            {
                abs.Abs();
                Console.WriteLine("IF YOUR CREDENTIALS ARE CORRECT PRESS \'1' OR PRESS ANY KEY ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a != 1);
        }
    }
}
