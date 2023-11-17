using System;
namespace program
{
    public class Employee
    {
        public float salary = 50000;
    }
    public class programmer : Employee
    {
        public float bonus = 10000;
    }
    class program
    {
        public static void Main(string[]args)
        {
            programmer p = new programmer();
            Console.WriteLine("salary:" + p.salary);
            Console.WriteLine("bonus:" + p.bonus);

        }
    }
}