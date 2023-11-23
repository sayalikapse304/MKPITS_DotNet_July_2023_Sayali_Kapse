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
            Console.WriteLine("array list collection");
            foreach (object obj in ar)
            {
                Console.WriteLine("student roll no:" + obj);
            }
            ar.Insert(2,17);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("array list collection after adding element at 2 position");
            foreach (object obj in ar)
            {
                Console.WriteLine("student roll no:" + obj);
            }
        }
    }
}

