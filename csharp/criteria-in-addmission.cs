using System;

namespace program
{ 
    class criteria
{
    public static void Main()
    {
        int math, phy, chem, tot;
        Console.WriteLine("enter the marks of math");
        math = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter the marks of phy");
        phy = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter the marks of chem");
        chem = Convert.ToInt32(Console.ReadLine());

        tot = math + phy + chem;
            Console.WriteLine("total marks:" + tot);
        if (tot >= 180)
        {
            Console.WriteLine("The candidate is eligible for admission.");
        }
        else
        {
            Console.WriteLine("The candidate is not  eligible for admission.");
        }
        Console.ReadKey();
    }
}
}