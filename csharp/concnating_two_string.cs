﻿using System;
class Program
{
    static void Main()
    {
        string s1 = "Good";
        string s2 = "Morning";
        string s3 = string.Concat(s1, s2);
        Console.WriteLine(s3);
        Console.ReadLine();
    }
}