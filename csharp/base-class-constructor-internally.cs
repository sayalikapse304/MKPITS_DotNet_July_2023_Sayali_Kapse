using System;
using System.Reflection;

namespace program
{
    class Company
    {
        public string name = "mkcl";
        public Company()
        {
            Console.WriteLine("base class constructor");
            Console.WriteLine("company name:" + name);
        }
    }
    class TCS : Company
    {
        public string name = "mkpits";
        public TCS()
        {
            Console.WriteLine("derived class constructor");
            Console.WriteLine("Tcs name :" + name);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            TCS t = new TCS();
            
            Console.ReadKey();
        }
    }
}
