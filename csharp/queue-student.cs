using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp39
{
    class student
    {
        public int rno;
        public string name;
        public student(int rno, string name)
        {
            this.rno = rno;
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(11, "amit");
            student s2 = new student(12, "ravi");
            student s3 = new student(13, "manish");
            Queue s = new Queue();
            s.Enqueue(s1);
            s.Enqueue(s2);
            s.Enqueue(s3);
            foreach (student val in s)
            {
                Console.WriteLine("rno " + val.rno);
                Console.WriteLine("name " + val.name);
            }

            student r = (student)s.Dequeue();
            Console.WriteLine("item deque " + r.rno + " : " + r.name);
            Console.WriteLine("after deque ");
            foreach (student val in s)
            {
                Console.WriteLine("name " + val.name);
            }
            

            Console.ReadLine();
        }
    }
}