using System;
namespace program
{
    class Employee
    {
        int empno;
        string empname;
        string designation;
        int salary;

        public Employee()
        {
            empno = 1234;
            empname = "sayali";
            designation= "maneger";
            salary = 80000;
        }
        public void displaydata()
        {
            Console.WriteLine("empno:" + empno);
            Console.WriteLine("empname:" + empname);
            Console.WriteLine("designation:" + designation);
            Console.WriteLine("salary:" + salary);
        }
    }
    class program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee();
            e.displaydata();
            Console.ReadKey();
        }
    }
}