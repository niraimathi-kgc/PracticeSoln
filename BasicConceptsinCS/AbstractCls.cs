using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConceptsinCS
{
    abstract class AbstractCls
    {
        public abstract void Abs();


    }
    class Abs2 : AbstractCls
    {
        public override void Abs()
        {
            Console.WriteLine("As you've confirmed Computer engineering as your couse... ");
            Console.WriteLine("You will get the Course Details below...");
            Console.WriteLine();
            Console.WriteLine("\tENTER YOUR CREDENTIALS ");
            Console.WriteLine("FORMAT: *******@gmail.com & 1234567890 ");
            Console.WriteLine();

        }
    }
        class Abs3 : AbstractCls
        {
            public override void Abs()
            {
                long a/*, i*/;
                string b;
            //Console.WriteLine("As you've confirmed Computer engineering as your cource... ");
            //Console.WriteLine("You will get the Course Details below...");
                Console.WriteLine("Enter your Gmail and Contact to continue: ");
                b = Console.ReadLine();
                a = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("your Gmail is : {0} ;\t Contact Number : {1}\n", b, a);
            }
        }
    
}
