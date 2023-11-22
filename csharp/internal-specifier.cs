using System;
namespace program
{
    class student
    {
        internal int rollno;
        internal string name;
        public void displaydata()
        {
            Console.WriteLine("roll no:" + rollno);
            Console.WriteLine("name:" + name);
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            student std = new student();
            std.rollno = 22;
            std.name = "sayali";
            std.displaydata();
            Console.ReadKey();
        }
    }
}