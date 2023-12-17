using System;
public class Program
{
    public static void Main()
    {
        string str;
        Console.WriteLine("Enter the String in Uppercase :");
        str = Console.ReadLine();
        Console.WriteLine("String in LowerCase : {0}", str.ToLower());
        Console.ReadLine();
    }
}