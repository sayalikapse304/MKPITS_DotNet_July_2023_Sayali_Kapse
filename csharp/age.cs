using System;
namespace program
{
    class age
    {

        public static void Main()
        {
            int age;
            Console.WriteLine("enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than" + age);
            Console.ReadLine();
        }
    }
}
