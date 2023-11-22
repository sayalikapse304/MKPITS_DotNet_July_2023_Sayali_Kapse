using System;
namespace program
{
    class student
    {
        protected string name;
        public void getdata()
        {
            name = "sayali";
            Console.WriteLine("name:" + name);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            student std = new student();
            std.getdata();
            Console.ReadKey();
        }
    }
}


