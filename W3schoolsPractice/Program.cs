using System;

namespace W3schoolsPractice
{
    class Null1
    {
        private string inacc = "InAccessible";
    }
    class Program
    {
        string color = "green";
        int speed = 120;
        static void MyMethod(string a, int b)
        {
            Console.WriteLine("This is the para printed while executing \'MyMethod'");
            Console.WriteLine("this is " + a + " here and i\'m " + b);

        }
        static int sum(int x, int y)
        {
            Console.WriteLine("This is the para printed while executing \'sum' method ");
            return x + y;
        }
        public int sub(int x, int y)
        {
            
            Console.WriteLine(x - y);
            Console.WriteLine("This is the paragraph is printed while executing \'sub' method ");
            return 0;
        }
        static void Main(string[] args)
        {
            int x, y, z;
            string name;
            Console.WriteLine("Hello World! this is from main method");
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age: ");
            z = Convert.ToInt32(Console.ReadLine());
            MyMethod(name, z);

            Console.WriteLine("Enter the paramerters to add two numbers");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sum(x, y));  //we can call the method without creating any object when it is in static
            Console.WriteLine();

            Program pgm = new Program();
            Console.Write("The class variable is accessed and the output value of color is shown: ");
            Console.WriteLine(pgm.color);  //to access the class variable globally declared

            Console.Write("The class variable is accessed and the output value of speed is shown: ");
            Console.WriteLine(pgm.speed+"km/hr");
            Console.WriteLine();

            //we can access the publicly assigned method outside main by creating object for the class
            Console.Write("the subtraction value of " + x + " and " + y + " are ");
            pgm.sub(x, y);

            /* Access Modifier - Private is used in the string inside Null1 class*/

            Null1 tried = new Null1(); //to access the string change to public string in that class 
            //Console.WriteLine(tried.inacc);

            Car myCar = new Car();
            Console.Write("Which brand you need in Vehicles: ");
            myCar.brand = Console.ReadLine();
            Console.Write("Which model you need in "+myCar.brand+": ");
            myCar.Model = Console.ReadLine();
            myCar.horn();

            Console.WriteLine();
            FileHandle.FileHandle1();
            
        }
    }
}
