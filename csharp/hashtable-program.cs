using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("01", "zara ali");
            ht.Add("02", "sayali");
            ht.Add("03", "payal");
            ht.Add("04", "achal");
            if (ht.ContainsValue("asmi"))
            {
                Console.WriteLine("the student name is already in a list");
            }
            else
            {
                ht.Add("05", "asmi");
            }
            ICollection key= ht.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k + ":" + ht[k]);
            }
                Console.ReadKey();


            

        }
    }
}

