using System;
namespace program
{
    class Student
    {
        int rno;
        string name;
        string course;
        int fees;

        public void getdata()
        {
            rno = 22;
            name = "sayali";
            course = "Dot Net";
            fees = 65000;
        }
        public void getdata(int rno, string name)
        {
            this.rno = rno;
            this.name = name;
        }
        public void getdata(int rno, string name, string course)
        {
            this.rno = rno;
            this.name = name;
            this.course = course;
        }
        public void getdata(int rno, string name, string course, int fees)
        {
            this.rno = rno;
            this.name = name;
            this.course = course;
            this.fees = fees;
        }
        public void display()
        {
            Console.WriteLine("rno:" + rno);
            Console.WriteLine("name:" + name);
            Console.WriteLine("course:" + course);
            Console.WriteLine("fees:" + fees);
        }
    }
    class program
    {
        static void Main(string[] args)
        {

            Student s = new Student();
            s.getdata();
            s.display();
            Console.WriteLine("------------------------------------------------");

            Student s1 = new Student();
            s1.getdata(22, "sayali");
            s1.display();
            Console.WriteLine("------------------------------------------------");

            Student s2 = new Student();
            s2.getdata(22, "sayali", "csharp");
            s2.display();
            Console.WriteLine("------------------------------------------------");

            Student s3 = new Student();
            s3.getdata(24, "santosh", "java", 4000);
            s3.display();
            Console.WriteLine("------------------------------------------------");

            Console.ReadLine();
        }
    }
}
           

   