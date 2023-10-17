using System;
namespace program
{
class triangle
{
    public static void Main()
    {
        int angal1, angal2, angal3, sum;
        Console.Write("angle 1 of triangle: ");
        angal1 = Convert.ToInt32(Console.ReadLine());

        Console.Write(" angle 2 of triangle: ");
        angal2 = Convert.ToInt32(Console.ReadLine());

        Console.Write(" angle 3 of triangle: ");
        angal3 = Convert.ToInt32(Console.ReadLine());

        sum = angal1 + angal2+ angal3;

        
        if (sum == 180)
        {
            Console.Write("The triangle is valid");
        }
        else
        {
            Console.Write("The triangle is not valid");
        }
        Console.ReadKey();
    }
}
}