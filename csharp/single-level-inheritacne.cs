using System;
namespace prpgram
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating.....");
        }
    }
    public class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking......");
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            Dog d = new Dog();
            d.eat();
            d.bark();
        }

    }
}