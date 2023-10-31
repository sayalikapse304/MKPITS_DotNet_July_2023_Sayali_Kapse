using System;
namespace program
{
    class circal
    {
        int radius;
        float area;
        float circ;
        public void getdata(int radius)
        {
            this.radius = radius;
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
        }
        public void displaydata()
        {
            Console.WriteLine("area of circal:" + area);
            Console.WriteLine("area of circumferance:" + circ);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            circal c1 = new circal();
            c1.getdata(7);
            c1.displaydata();
            Console.ReadKey();
        }
    }

}
  