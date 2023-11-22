using System;
namespace program
{
    class employee
    {
        public string empname { get; set; }
    }
    class program
    {
        static void Main(string[]args)
        {
            employee emp = new employee();
            emp.empname = "sayali";
            Console.WriteLine("employee name:" + emp.empname);


        }
    }
}