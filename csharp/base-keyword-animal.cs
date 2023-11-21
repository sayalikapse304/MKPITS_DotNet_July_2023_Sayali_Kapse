using System;
using System.Reflection.Metadata;

namespace program
{
    class Animal
    {
        public string color = "white";
    }
    class Dog : Animal
    {
        public string color = "black";
        public void displaycolor()
        {
            Console.WriteLine("dog color:" + color);
            Console.WriteLine("animal color:" + base.color);

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.displaycolor();
            Console.ReadKey();
        }
    }

            
}