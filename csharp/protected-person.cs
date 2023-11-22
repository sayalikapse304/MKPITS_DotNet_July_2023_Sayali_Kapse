using System;
namespace program
{
    class person
    {
        protected string name;

    }
    
    class student : person
    {
        public void getdata()
        {
            name = "ravi";
            Console.WriteLine("name " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
          
            s.getdata();
        }
    }
}
