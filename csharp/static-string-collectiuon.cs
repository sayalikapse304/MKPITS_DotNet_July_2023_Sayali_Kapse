using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push("amar");
            s.Push("ravi");
            s.Push("antoni");
            foreach (string val in s)
            {
                Console.WriteLine("name " + val);
            }
            s.Push("ankita");
            Console.WriteLine("last item added " + s.Peek());
            Console.WriteLine("after peek method");
            foreach (string val in s)
            {
                Console.WriteLine("name " + val);
            }
            Console.WriteLine("last item added " + s.Pop());
            Console.WriteLine("after pop method");
            foreach (string val in s)
            {
                Console.WriteLine("name " + val);
            }

            Console.WriteLine("last item added " + s.Pop());
            Console.WriteLine("after pop method");
            foreach (string val in s)
            {
                Console.WriteLine("name " + val);
            }

            Console.ReadLine();
        }
    }
}