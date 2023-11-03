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
        designation = "maneger";
        salary = 80000;
    }
    public Employee(int empno, string empname, string designation, int salary)
    {
        this.empno = empno;
        this.empname = empname;
        this.designation = designation;
        this.salary = salary;
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
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("enter emp no");
        int en = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter empname");
        string name = Console.ReadLine();
        Console.WriteLine("enter designation");
        string d= Console.ReadLine();
        Console.WriteLine("enter salary");
        int sal = Convert.ToInt32(Console.ReadLine());
        Employee e2 = new Employee(en, name, d, sal);
        e2.displaydata();



    }
}
