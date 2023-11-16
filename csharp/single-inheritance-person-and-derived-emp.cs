using System;
namespace program
{
     public class Person
    {
        public string name;
        public string address;
    }
    public class Employee: Person
    {
        public int empno;
        public int salary;
    }
    class program
    {
        public static void Main(string[] args)
        {
            Employee e = new Employee();
            e.name = "sayali";
            e.address = "palandur";
            e.empno = 22;
            e.salary = 5000;

            Console.WriteLine("name:" + e.name);
            Console.WriteLine("address:" + e.address);
            Console.WriteLine("empno:" + e.empno);
            Console.WriteLine("salary:" + e.salary);

        }

    }
}

