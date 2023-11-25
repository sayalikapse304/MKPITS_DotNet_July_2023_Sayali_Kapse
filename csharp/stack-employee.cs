using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace program
{
    class Employee
    {
        public int empno;
        public string name;
        public int salary;
        public string designation;
        public Employee(int empno, string name, int salary, string designation)
        {
            this.empno = empno;
            this.name = name;
            this.salary = salary;
            this.designation = designation;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "sayali", 200000, "owener");
            Employee e2 = new Employee(2, "mayuri", 80000, "maneger");
            Employee e3 = new Employee(3, "vrushali", 40000, "clerk");
            Stack st = new Stack();
            st.Push(e1);
            st.Push(e2);
            st.Push(e3);

            foreach (Employee e in st)
            {
                Console.WriteLine("empno: " + e.empno);
                Console.WriteLine("name: " + e.name);
                Console.WriteLine("salary: " + e.salary);
                Console.WriteLine("designation: " + e.designation);
                Console.WriteLine("------------------------------------");
            }
            Console.WriteLine("after poping------");
            st.Pop();
            st.Pop();
            foreach (Employee e in st)
            {
                Console.WriteLine("empno: " + e.empno);
                Console.WriteLine("name: " + e.name);
                Console.WriteLine("salary: " + e.salary);
                Console.WriteLine("designation: " + e.designation);
            }
            Console.ReadLine();
        }
    }
}


        



