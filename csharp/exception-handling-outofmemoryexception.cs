﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "sayali";
            string subject = "math";
            Console.WriteLine("length of name " + name.Length);
            StringBuilder sb = new StringBuilder(name.Length, name.Length);
                try
            {
                sb.Append(subject);
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("bye");
        }
    }
}
            

            