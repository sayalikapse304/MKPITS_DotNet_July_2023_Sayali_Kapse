using System;
using System.Collections;
using System.Linq;

namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("de", "germany");
            dic.Add("ie", "India");
            dic.Add("us", "United state");
            dic.Add("sk", "solvakia");
            dic.Add("hu", "hungary");

            Console.WriteLine(dic["ie"]);
            Console.WriteLine(dic["de"]);


            Console.WriteLine("dictionary has{0} items", dic.Count);
            Console.WriteLine("keys of the dictionary:");
            List<string> li = new List<string>();
            foreach (string key in li)
            {
                Console.WriteLine("{0}", key);
            }
            Console.WriteLine("values of the dictionary:");
            List<string> val = new List<string>();
            foreach (string vals in val)
            {
                Console.WriteLine("{0}", vals);
            }
            Console.WriteLine("keys and values of the dictionary:");

            foreach (KeyValuePair<string, string> kvp in dic)
            {
                Console.WriteLine("key={0}, value ={1}", kvp.Key, kvp.Value);
            }


        }
    }
}