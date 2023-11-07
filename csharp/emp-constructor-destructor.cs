using System;
namespace program
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Constructor called");
        }
        ~Employee()
        {
            Console.WriteLine("Destructor called");
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.ReadKey();
            Employee emp1 = new Employee();
            Console.ReadKey();
        }
    }
}
     