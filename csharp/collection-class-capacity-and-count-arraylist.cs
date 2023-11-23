using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(11);
            ar.Add(12);
            ar.Add(13);
            foreach (object obj in ar)
            {
                Console.WriteLine("student roll no" + obj);
            }
            Console.WriteLine("capacity:{0}", ar.Capacity);
            Console.WriteLine("count:{0}", ar.Count);


        }
    }
    
}
    