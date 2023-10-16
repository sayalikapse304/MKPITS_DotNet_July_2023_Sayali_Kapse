using System;

namespace program
{
    class marks
    {
        public static void Main()
        {
            int sub1, sub2, sub3;
            float per, tot;
            string grade;
            Console.WriteLine("enter  3 Subject markes");
            sub1 = Convert.ToInt32(Console.ReadLine());
            sub2 = Convert.ToInt32(Console.ReadLine());
            sub3 = Convert.ToInt32(Console.ReadLine());
            tot = sub1 + sub2 + sub3;
            Console.WriteLine("total markes=" + tot);

            per = tot / 300 * 100.0f;
            Console.WriteLine("percentage=" + per);

            if (per >= 75)
            {
                grade = "distinction";
            }
            else if (per >= 60 && per < 75)
            {
                grade = "first class";
            }
            else
            {
                grade = "fail";
            }
                Console.WriteLine("grade:" + grade);
                Console.ReadKey();
            }
            }
        }
            
           





