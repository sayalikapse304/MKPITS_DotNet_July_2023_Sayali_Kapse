using System;
namespace program
{
    class ProtectedTest
    {
        protected string name = "Shashikant";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program : ProtectedTest
    {
        static void Main(string[] args)
        {
            Program program = new Program();
         
            Console.WriteLine("Hello " + program.name);
            
            program.Msg("Swami Ayyer");
        }
    }
}  

