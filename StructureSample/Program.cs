using System;

namespace StructureSample
{
    class Program
    {
        struct Vehicles
        {
            int Speed;
            string Name;
            string Type;
            double Price;

            public void Credentials(int s, string n, string t, double p)
            {
                Speed = s;
                Name = n;
                Type = t;
                Price = p;
            }

            public void Output()
            {
                Console.WriteLine("Type of the vehicle : {0}", Type);
                Console.WriteLine("Name of the vehicle : {0}", Name);
                Console.WriteLine("Speed of the vehicle : {0}km/h", Speed);
                Console.WriteLine("Price of the vehicle : {0}lakhs ", Price);
                Console.WriteLine();
            }
        };
        static void Main(string[] args)
        {
            Vehicles vehicle1 = new Vehicles();
            Vehicles vehicle2 = new Vehicles();
            int s;
            string t, n;
            double p;

            Console.Write("Enter the type of vehicle : ");
            t = Console.ReadLine();
            Console.Write("Enter the Name of vehicle : ");
            n = Console.ReadLine();
            Console.Write("Enter the Speed of vehicle : ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Price of vehicle : ");
            p = Convert.ToDouble(Console.ReadLine());

            vehicle1.Credentials(s, n, t, p);
            Console.WriteLine();
            Console.Write("Enter the type of vehicle : ");
            t = Console.ReadLine();
            Console.Write("Enter the Name of vehicle : ");
            n = Console.ReadLine();
            Console.Write("Enter the Speed of vehicle : ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Price of vehicle : ");
            p = Convert.ToDouble(Console.ReadLine());
            vehicle2.Credentials(s, n, t, p);
            Console.WriteLine();
            Console.WriteLine("Vehicle 1 :");
            vehicle1.Output();
            Console.WriteLine("Vehicle 2 :");
            vehicle2.Output();
        }
    }
    
}
