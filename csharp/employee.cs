using System;
namespace program
{
    class Employee
    {
        int emp_no;
        string emp_name;
        string emp_designation;
        int emp_salary;
        public void getdata(int no, string name, string designation, int sal)
        {
            emp_no = no;
            emp_name = name;
            emp_designation = designation;
            emp_salary = sal;
        }
        public void displaydata()
        {
            Console.WriteLine("emp number:" + emp_no);
            Console.WriteLine("emp name:" + emp_name);
            Console.WriteLine("emp designation:" + emp_designation);
            Console.WriteLine("emp salary:" + emp_salary);

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getdata(1234, "sayali", "manager", 50000);
            emp.displaydata();
            Console.ReadKey();
        }
    }
}
    

