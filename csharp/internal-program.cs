using System;
namespace AccessSpecifiers
{
    class InternalTest
    {
        internal string name = "Shantosh Kumar";
        internal void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            InternalTest internalTest = new InternalTest();
          
            Console.WriteLine("Hello " + internalTest.name);
           
            internalTest.Msg("Peter Decosta");
        }
    }
}
