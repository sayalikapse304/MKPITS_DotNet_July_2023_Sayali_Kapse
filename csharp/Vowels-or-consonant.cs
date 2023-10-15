using System;
using System.Net.NetworkInformation;

namespace program
{
    class vowels
    {
        public static void Main()
        {
            char ch;
            Console.WriteLine("Enter the Charachter ");
            ch = Convert.ToChar(Console.ReadLine());
            
            if (ch == 'a' ||  ch == 'e' ||ch == 'i' ||  ch == 'o' ||  ch == 'u' )
            {
                Console.WriteLine("It is a vowel" );
            }
            else
            {
                Console.WriteLine("It is consonant");
            }
            Console.ReadKey();
        }
    }
} 
       