using System;
using System.Collections.Generic;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            Stack<int> stc = new Stack<int>();

            stc.Push(1);
            stc.Push(4);
            stc.Push(3);
            stc.Push(6);
            stc.Push(4);

            Console.WriteLine(stc.Pop());
            
            Console.WriteLine(stc.Peek());
            Console.WriteLine(stc.Peek());
            


            Console.WriteLine();

            foreach (int item in stc)
            {
                Console.WriteLine(item);
            }
        }
    }
}