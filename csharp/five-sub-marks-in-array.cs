using System;
namespace program
{
    class variable
    {
        static void Main(string[] args)
        {
            int[] sub = new int[5];
            float tot = 0, per;
            string grade = null ;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter subject marks");
                sub[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                tot = tot + sub[i];
            }
            Console.WriteLine("total=" + tot);
            per = tot /500.0f * 100.0f;

                if (per >= 75)
                {
                    grade = "A";
                }
                else if (per > 60 && per < 75)
                {
                    grade = "B";
                }
                else if (per > 35 && per < 60)
                {
                    grade = "C";
                }
                else
                {
                    grade = "fail";
                }

            
                
                Console.WriteLine("per=" + per);
                Console.WriteLine("grade=" + grade);
            
        Console.ReadKey();
            }
}
}



       