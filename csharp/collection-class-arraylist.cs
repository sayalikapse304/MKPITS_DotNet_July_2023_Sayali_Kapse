using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("sayali");
            ar.Add("Achal");
            ar.Add("munni");
            foreach (object obj in ar)
            {
                Console.WriteLine("name:" + obj);
            }
        }
    }
}