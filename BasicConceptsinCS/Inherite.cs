using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConceptsinCS
{

    public class Inherite /*: IInterface1, IInterface2*/
    {
        public void IInterface()
        {
            Console.WriteLine("Interface method 1");
        }
        public void IInterface2()
        {
            Console.WriteLine("Interface Method 2");
        }
        public void ClassDerived()
        {
            Console.WriteLine("Derived Class method 1");
        }
    }
}
