using System;
using System.Collections.Generic;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            li.Add("java");
            li.Add("c");
            li.Add("c++");
            Console.WriteLine(li[1]);
            Console.WriteLine(li[2]);
            li.Remove("c");
            li.Remove("c++");

            Console.WriteLine(li.Contains("c"));

            li.Insert(1, "php");
            li.Sort();
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }
        }
    }
}







       