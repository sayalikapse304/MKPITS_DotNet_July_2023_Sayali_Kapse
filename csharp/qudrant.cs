using System;

namespace program
    class quadrant
    {
        public static void Main()
        {
            int x,y;
            Console.WriteLine("input the value of x coordinate:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input the value of y coordinate:");
            y = Convert.ToInt32(Console.ReadLine());


            if (x>0 && y>0)
            {
                Console.WriteLine("the coordinate point"+(x,y)+ "lies in the first quadrant");
            }
           else if (x > 0 && y < 0)
            {
                Console.WriteLine("the coordinate point" + (x, y) + "lies in the seconde quadrant");
            }
            else if (x < 0 && y <0)
            {
                Console.WriteLine("the coordinate point" + (x, y) + "lies in the third quadrant");
            }
            else if(x <0 && y > 0)
            {
                Console.WriteLine("the coordinate point" + (x, y) + "lies in the forth quadrant");
            }
            Console.ReadKey();

        }
    }
}