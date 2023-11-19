using System;
namespace program
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating------------");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread------------ ");
        }
    }
    public class program
    {
        public static void Main()
        {
            Animal d = new Dog();
                d.eat();
        }
    }

}