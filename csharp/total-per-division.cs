using System;
namespace program
{
    class marks
    {
        public static void Main()
        {
            int rollno, phy, chem, computer, tot;
            string name, division;
            float per;
            Console.WriteLine("enter rollno");
            rollno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name");
            name = (Console.ReadLine());

            Console.WriteLine("marks of 3 subject");
            phy = Convert.ToInt32(Console.ReadLine());
            chem = Convert.ToInt32(Console.ReadLine());
            computer = Convert.ToInt32(Console.ReadLine());

            tot = phy + chem + computer;
            Console.WriteLine("total marks=" + tot);

            per = tot / 300.0f * 100.0f;
            Console.WriteLine("per =" + per);

            if (per >= 75)
            {
                division = "first class";

            }
            else if (per >= 60 && per < 75)
            {
                division = "seconde class";

            }
            else
            {
                division = "fail";
            }
            Console.WriteLine("Division=" + division);
            Console.ReadKey();
        }
    }
}