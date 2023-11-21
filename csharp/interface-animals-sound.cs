using System;
namespace program
{
    interface Animals
    {
        string makesound();
    }
    class Dog : Animals
    {
        public string makesound()
        {
            return "dog sound is bhoooooo----------";
        }
    }
    class cat : Animals
    {
        public string makesound()
        {
            return "cat sound is mew mew ------------";
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Animals a = new Dog();
            string res = a.makesound();
            Console.WriteLine(res);
            Animals c = new cat();
            string res2 = c.makesound();
            Console.WriteLine(res2);
            Console.ReadKey();
        }
    }
}







