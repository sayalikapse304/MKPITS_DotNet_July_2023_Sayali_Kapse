using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(19);
            ar.Add(22);
            ar.Add(3);
            Console.WriteLine("array list collection without sorting");
            foreach (object obj in ar)
            {
                Console.WriteLine("student roll no:" + obj);
            }
            ar.Sort();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("array list collection with sorting");
            foreach (object obj in ar)
            {
                Console.WriteLine("student roll no:" + obj);
            }
        }
    }
}

