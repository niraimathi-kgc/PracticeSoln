using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConceptsinCS
{
    sealed partial class PartialClassN
    {
        public void Part3()
        {
            string a;
            //PartialClassN ptl = new PartialClassN();
            ////ptl.Part2();

            //Console.WriteLine("your name is : " + ptl.Part1());
            Console.WriteLine("Which course you want to select : ");
            a = Console.ReadLine();
            Console.WriteLine("Congrats, You've Successfully Selected {0}. ",a);
        }
    }
}
