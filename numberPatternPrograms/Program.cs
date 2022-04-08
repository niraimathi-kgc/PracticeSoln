using System;

namespace numberPatternPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern1 p1 = new Pattern1();
            Pattern2 p2 = new Pattern2();
            Pattern3 p3 = new Pattern3();
            Pattern4 p4 = new Pattern4();
            Pattern5 p5 = new Pattern5();
            Pattern6 p6 = new Pattern6();
            Pattern7 p7 = new Pattern7();
            Pattern8 p8 = new Pattern8();
            Pattern9 p9 = new Pattern9();
            Pattern10 p10 = new Pattern10();
            int a = 1, i;
            
            do
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("\tNUMBER PATTERN PROGRAMS USING C#");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Press the specific functional button to call the number pattern ");
                Console.WriteLine("1 -> PATTERN 1");
                Console.WriteLine("2 -> PATTERN 2");
                Console.WriteLine("3 -> PATTERN 3");
                Console.WriteLine("4 -> PATTERN 4");
                Console.WriteLine("5 -> PATTERN 5");
                Console.WriteLine("6 -> PATTERN 6");
                Console.WriteLine("7 -> PATTERN 7");
                Console.WriteLine("8 -> PATTERN 8");
                Console.WriteLine("9 -> PATTERN 9");
                Console.WriteLine("10 -> PATTERN 10");
                Console.WriteLine("-------------------------------------------------------");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        p1.numPat1();
                        Console.WriteLine();
                        break;
                    case 2:
                        p2.numPat2();
                        Console.WriteLine();
                        break;
                    case 3:
                        p3.numPat3();
                        Console.WriteLine();
                        break;
                    case 4:
                        p4.numPat4();
                        Console.WriteLine();
                        break;
                    case 5:
                        p5.numPat5();
                        Console.WriteLine();
                        break;
                    case 6:
                        p6.numPat6();
                        Console.WriteLine();
                        break;
                    case 7:
                        p7.numPat7();
                        Console.WriteLine();
                        break;
                    case 8:
                        p8.numPat8();
                        Console.WriteLine();
                        break;
                    case 9:
                        p9.numPat9();
                        Console.WriteLine();
                        break;
                        case 10:
                        p10.numPat10();
                        break;
                    default:
                        Console.WriteLine("Enter a correct pattern to access the pattern programs... ");
                        break;

                }
                Console.Write("To Continue... Press ANY KEY or press 1 to exit: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            } while (a != 1);
        }
    }
}
