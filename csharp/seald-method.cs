using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class person
    {
        public virtual void display()
        {
            Console.WriteLine("hello from person");
        }
    }
    class student : person
    {
        public string name;
        public sealed override void display()
        {
            Console.WriteLine("hello");
        }
    }
    class parttime : student
    {
        /*
        public  override void display() //error since sealed
        {
            Console.WriteLine("hello");
        }
        */
    }


    class Program
    {
        static void Main(string[] args)
        {
            parttime p = new parttime();
            p.display();
        }
    }
}