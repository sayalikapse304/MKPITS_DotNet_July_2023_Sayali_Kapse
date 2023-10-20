using System;
namespace program
{
    class number
    {
        public static void Main()
        {
            int sub;
            string grade;
            int tot = 0;
            float per = 0.0f;
            for (int cnt = 1; cnt <= 5; cnt++)
            {

                Console.WriteLine("enter subject marks");
                sub = Convert.ToInt32(Console.ReadLine());


                tot = tot + sub;
                per = tot / 500.0f * 100.0f;
            }
                
                if (per > 75)
                {
                    grade = "A";
                }
                else if (per > 60 && per < 75)
                {
                    grade = "B";
                }
                else
                {
                    grade = "fail";
                }
            Console.WriteLine("tot=" + tot);

            Console.WriteLine("per=" + per);

            Console.WriteLine("Grade=" + grade);
            
            
            Console.ReadKey();
        }
    }
}

     