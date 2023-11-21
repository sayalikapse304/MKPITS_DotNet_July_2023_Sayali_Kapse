using System;
namespace program
{
    interface Readable
    {
        string readdata();
        string writedata(string data);
    }
    interface writeable
    {
        string readdata();
        string writedata(string data);
    }
    class FileHandler : Readable, writeable
    {
        public string readdata()
        {
            return "readdata";
        }
        public string writedata(string data)
        {
            return "writedata";
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            Readable r = new FileHandler();
            string res = r.readdata();
            Console.WriteLine(res);
            string res2 = r.writedata("hii from writedata");
            Console.WriteLine(res2);

           
            writeable w = new FileHandler();
            string res1 = w.readdata();
            Console.WriteLine(res1);
            string res3 = w.writedata("hii from writedata");
            Console.WriteLine(res3);

            Console.ReadKey();

        }
    }
}