using System;
namespace program
{
    public class Person
    {
        public string name;
        public string address;
    }
    public class Student : Person
    {
        public int rno;
        public int marks;
    }
    class program
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.name = "sayali";
            s.rno = 22;
            s.address = "palandur";
            s.marks = 500;

            Console.WriteLine("name:" + s.name);
            Console.WriteLine("address:" + s.address);
            Console.WriteLine("rno:" + s.rno);
            Console.WriteLine("marks:" + s.marks);

        }

    }
}
        
       