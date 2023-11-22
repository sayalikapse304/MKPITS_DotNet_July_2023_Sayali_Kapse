
using System;
namespace program
{
    class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    class program
    {
        static void Main(string[] args)
        {
            student std = new student();
            std.Id = 123;
            std.Name = "sayali";
            std.Email = "sayalikapse53@gmail.com";

            Console.WriteLine("Id:" + std.Id);
            Console.WriteLine("Name:" + std.Name);
            Console.WriteLine("Email:" + std.Email);
        }
    }
}


       