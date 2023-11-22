using System;
using System.ComponentModel.DataAnnotations;

namespace program
{
    class employee
    {
        public string name = "santosh sarode";
        public void msg(string msg)
        {
            Console.WriteLine("hello " + msg);
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            employee emp = new employee();
            Console.WriteLine("hello " + emp.name);
            emp.msg("How are you!");
            Console.ReadKey();
        }
    }
}