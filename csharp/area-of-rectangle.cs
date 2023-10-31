using System;
namespace program
{
    class Rectangle
    {
        int width;
        int height;
        float area;
        public void getdata(int width, int height)
        {
            this.width = width;
            this.height = height;
            area = width * height;

        }
        public void displaydata()
        {
            Console.WriteLine("area of rectangle:" + area);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            
            r.getdata(5, 10);
            r.displaydata();
            Console.ReadKey();
        }
    }
}