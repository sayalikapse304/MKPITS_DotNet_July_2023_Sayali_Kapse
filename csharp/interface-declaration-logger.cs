using System;
namespace program
{
    interface Logger
    {
        string logmessage(string message);
        string logerror(string error);
    }
    class consoleLogger : Logger
    {
        public string logmessage(string message)
        {
            return "message";
        }
        public string logerror(string error)
        {
            return "error";
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            Logger l;
            l = new consoleLogger();
            string res = l.logmessage("hello");
            Console.WriteLine(res);
            res = l.logerror("logerror");
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}