using System;

namespace ExtensionMethod
{
    public class PracticeCalc
    {
        public void Calc1()
        {
            Console.WriteLine("Method 1 inside PracticeCalc class");
        }

        public void Calc2()
        {
            Console.WriteLine("Method 2 inside PracticeCalc class");
        }
    }
    static public class PracticeCalc2
    {
        public static void Calc3(this PracticeCalc practiceCalc)
        {
            Console.WriteLine("This is the method 1 inside racticeCalc2 Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PracticeCalc practiceCalc = new PracticeCalc();
            practiceCalc.Calc1();
            practiceCalc.Calc2();
            practiceCalc.Calc3();
        }
    }
}
