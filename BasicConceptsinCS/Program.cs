using System;

namespace BasicConceptsinCS
{
    partial class PartialClassN
    {
        public void Part1()
        {
            string a;
            int b;
            Console.Write("Enter the name: ");
            a = Console.ReadLine();
            Console.Write("Enter the age: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Your name is {0} and your age is {1}",a,b);
            Console.WriteLine("Hey, {0}.",a);
            // return a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            PartialClassN ptl = new PartialClassN();
            
            //ptl.Part1();
            ptl.Part2();
            //ptl.Part3();
            ptl.Part3();
            Abs3 abs = new Abs3();
            Abs2 abs1 = new Abs2();
            abs1.Abs();
            //do
            //{
            //    abs.Abs();
            //    Console.WriteLine("IF YOUR CREDENTIALS ARE CORRECT PRESS \'1' OR PRESS ANY KEY ");
            //    a = Convert.ToInt32(Console.ReadLine());
            //} while (a!=1);
            StaticClass.StaticMethod();
            Inherite inh = new Inherite();
            Console.WriteLine("The below are printed from the multiple inheritance using interface: ");
            inh.ClassDerived();
            inh.IInterface();
            inh.IInterface2();

            Console.WriteLine("Practiced Constructor and method overload in a single class: ");
            Console.WriteLine();
            Console.WriteLine("Constructor overloading and method overloading is shown below...");
            ConstrOverload con = new ConstrOverload();
            con.Cons();
            con.Cons(2, 3);
            con.Cons(2, 4, 5);
            Console.WriteLine();
            Console.WriteLine("Method overriding is shown below...");
            Console.WriteLine();
            OverRideMeth ovr = new OverRideMeth();
            ovr.Cons();
            NormalMethods Normal = new NormalMethods();
            Normal.Method1();
            Normal.Method2();
        }
    }
}
