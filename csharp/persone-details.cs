using System;
namespace program
{
    class Person
    {

        string name;
        int age;
        string address;

        public void setvalue(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public void displaydata()
        {
            Console.WriteLine(" name:" + name);
            Console.WriteLine(" age:" + age);
            Console.WriteLine(" address:" + address);
        }
        }
    class program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine("enter name");
            string n = Console.ReadLine();
            Console.WriteLine("enter age");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter address");
            string add = Console.ReadLine();

            p1.setvalue(n, a, add);
            p1.displaydata();
            Console.ReadKey();
        }


        }
    }
           