﻿using System;
namespace program
{
    class ProtectedTest
    {
        protected internal string name = "Shashikant";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ProtectedTest pp = new ProtectedTest();
            pp.name = "ravi";
            Console.WriteLine(pp.name);

        }
    }
}

