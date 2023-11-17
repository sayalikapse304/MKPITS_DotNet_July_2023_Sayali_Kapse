using System;
using System.Runtime.InteropServices;

namespace program
{
    class Person
    {
        public string name;
    }
    class Student : Person
    {
        public int rno;
    }
    class program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.rno = 22;
            s.name = "sayali";
            Console.WriteLine("roll no:" + s.rno);
            Console.WriteLine("name:" + s.name);
            Console.ReadKey();
        }
    }
}