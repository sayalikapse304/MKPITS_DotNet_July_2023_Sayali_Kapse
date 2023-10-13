using System;
namespace program
{
    class sphere
    {
        public static void Main()
        {
            float r, surface, volume;
            Console.WriteLine("enter radius");
            r = Convert.ToSingle(Console.ReadLine());
            surface = 4 * 3.14f * r * r;
            volume = 4 / 3 * 3.14f * r * r * r;
            Console.WriteLine("surface of sphere=" + surface);
            Console.WriteLine("volume of sphere=" + volume);
            Console.ReadKey();
        }
    }
}

