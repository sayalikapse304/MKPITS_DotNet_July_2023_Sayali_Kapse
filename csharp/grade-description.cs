using System;
namespace program
{
    class grade
    {
        public static void Main()
        {
            char grd;
            String res;
            Console.WriteLine("grade");
             grd=Convert.ToChar (Console.ReadLine());


            if (grd == 'E')
            {
                res = "Excellent";
            }
                
            else if (grd=='V')
            {
                res = "Very Good"; 

            }
            else if(grd=='G')
            {
                res = "Good";
            }
            else
            {
                res = "fail";
            }
            Console.WriteLine("you have choosen:"+res);
            Console.ReadKey();
        }
    }
}