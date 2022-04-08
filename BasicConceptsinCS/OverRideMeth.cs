using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConceptsinCS
{
    class OverRideMeth : ConstrOverload
    {
        public override void Cons()
        {
            Console.WriteLine("The method has been overrided by \'OverRideMeth'");
        }
    }
}
