using System;
namespace program
{
    public class vehical
    {
        public int make;
        public string model;
    }
    class car : vehical
    {
        public int numdoors;
        public string fueltype;
    }
    class program
    {
        public static void Main(string[] args)
        {
            car v = new car();
            v.make = 2009;
            v.model = "maruti";
            v.numdoors = 4;
            v.fueltype = "petrol";
            Console.WriteLine("make:" + v.make);
            Console.WriteLine("model:" + v.model);
            Console.WriteLine("numdoors:" + v.numdoors);
            Console.WriteLine("fueltype:" + v.fueltype);
            Console.ReadKey();
        }
    }
}

