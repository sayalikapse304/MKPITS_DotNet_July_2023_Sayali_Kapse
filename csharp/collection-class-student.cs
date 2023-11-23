using System;
using System.Collections;
namespace ConsoleApp6
{
    class student
    {
        public int rno;
        public String name;
        public student(int rno, String name)
        {
            this.rno = rno;
            this.name = name;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            student s1 = new student(12, "amit");
            
            student s2 = new student(14, "raj");
            student s3 = new student(16, "raman");
            ArrayList al = new ArrayList();
            al.Add(s1);
            al.Add(s2);
            al.Add(s3);
          
            foreach (student s in al)
            {
                Console.WriteLine("rno " + s.rno);
                Console.WriteLine("name  " + s.name);
            }

        }
    }
}