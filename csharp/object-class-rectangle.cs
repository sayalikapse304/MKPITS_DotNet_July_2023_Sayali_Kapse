using System;
namespace program
{
    class Rectangle
    {
        int length;
        int breadth;

        public void getdata(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
           
        }
        public void displaydata()
        {
           int area = length * breadth;
            Console.WriteLine("area:" + area);
            
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.getdata(4, 3);
            r.displaydata();
            Console.ReadKey();
        }
    }
}
