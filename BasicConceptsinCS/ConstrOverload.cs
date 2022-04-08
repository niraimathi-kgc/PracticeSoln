using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConceptsinCS
{
    class ConstrOverload
    {
        public ConstrOverload()
        {
            Console.WriteLine("This is the CONSTRUCTOR without arguement...");
        }
        public ConstrOverload(int a, int b)
        {
            Console.WriteLine("This is the CONSTRUCTOR with arguements of a = {0} and b = {1}", a, b);
        }
        public ConstrOverload(int a, int b, int c)
        {
            Console.WriteLine("This is the CONSTRUCTOR with arguements of a = {0}, b = {1} and c = {2}", a, b, c);
            Console.WriteLine("the sum of CONSTRUCTOR a, b, c is {0}", (a + b + c));

        }
        public virtual void Cons()
        {
            Console.WriteLine("this is the line printed inside the METHOD");
        }
        public void Cons(int a, int b)
        {
            Console.WriteLine("This is the METHOD overload with two arguements a : {0} and b : {1}", a, b);
            Console.WriteLine("the sum of METHOD {0} and {1} is {2}", a, b, (a + b));
        }
        public void Cons(int a, int b, int c)
        {
            Console.WriteLine("This is the METHOD overload with three arguements a : {0}, b : {1} and c : {2}", a, b, c);
            Console.WriteLine("the sum of METHOD {0}, {1} and {2} is {3}", a, b, c, (a + b + c));
        }
    }
    
}
