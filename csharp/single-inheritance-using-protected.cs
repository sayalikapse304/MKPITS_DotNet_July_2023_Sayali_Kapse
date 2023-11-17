using System;
namespace program
{
    class Employee
    {
        protected int salary;
    }
    class Programmer : Employee
    {
        int bonus;
        public void getdata(int salary, int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void displaydata()
        {
            Console.WriteLine("salary:" + salary);
            Console.WriteLine("Bonus:" + bonus);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer();
            p.getdata(20000, 1000);
            p.displaydata();

        }
    }
}

