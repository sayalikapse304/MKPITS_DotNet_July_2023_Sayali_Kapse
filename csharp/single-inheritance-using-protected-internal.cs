using System;
namespace program
{
    public class Person
    {
        String name;
        String address;
        protected internal void getPersonData(String name, String address)
        {
            this.name = name;
            this.address = address;
        }
        
        protected internal void displayPersonData()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("address : " + address);

        }
    }
    public class employee : Person
    {
        int empno;
        int salary;
        public void getemployeeData(int empno, int salary)
        {
            this.empno = empno;
            this.salary = salary;
        }
        public void displayemployeeData()
        {
            Console.WriteLine("empno : " + empno);
            Console.WriteLine("salary: " + salary);

        }
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            employee p1 = new employee();
            p1.getPersonData("sayu", "nagpur");
            p1.getemployeeData(22, 8000);
            p1.displayemployeeData();
            p1.displayPersonData();

        }
    }

}

