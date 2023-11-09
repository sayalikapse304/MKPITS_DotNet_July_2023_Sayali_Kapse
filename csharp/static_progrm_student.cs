using System;
namespace program
{
    class Student
    {
        public static void display()
        {
            Console.WriteLine("hello");
        }
        public void sayhi()
        {
            Console.WriteLine("hii");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Student.display();
            Student s = new Student();
            s.sayhi();
            Console.ReadKey();
        }
    }
}
    