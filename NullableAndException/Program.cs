using System;

namespace NullableAndException
{
    class Program
    {
        enum Months
        {
            Jan,
            Feb,
            Mar = 5,
            April,
            May

        }
        static void Main(string[] args)
        {
            try
            {
                #region:nullable datatypes
                int? a;
                int? b = null;
                bool? boolean;
                boolean = true;
                a = b ?? 5;                //will assign the vallue of b if it is not null, if it is null. it will take the value given after ??
                Console.WriteLine("value of nullable int a, b and boolean : {0}, {1}, {2}", a, b, boolean);
                #endregion
                Console.WriteLine("enter an integer value: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

//#warning: after few lines you will find an error
                Months months = Months.Mar;

                Months months1 = Months.May;
                int c = Convert.ToInt32(months);
                int d = Convert.ToInt32(months1);
//#error: no coding should be processing here
                Console.WriteLine(months);
                Console.WriteLine(c);
                Console.WriteLine(months1);
                Console.WriteLine(d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("This is the exception block where you will find the errors");
            }
            finally
            {
                Console.WriteLine("The try... catch... functions are completed, you've came to finally statement");
            }
        }
    }
}
