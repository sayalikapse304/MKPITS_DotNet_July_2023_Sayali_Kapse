using System;
namespace program
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eat.....");
        }
    }
    public class dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("bark.....");
        }
    }
    public class babydog : dog
    {
        public void weep()
        {
            Console.WriteLine("weep.....");
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            babydog d = new babydog();
            d.eat();
            d.bark();
            d.weep();
        }
    }
}