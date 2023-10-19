using System;


namespace program
{
    class natural
    {
        public static void Main()
        {

            int num = 1;
            int sum = 0;
            while (num <= 7)
            {
                sum = sum + num;
                Console.WriteLine("natural num:" + num);
                num++;
            }

            
            Console.WriteLine("sum of natural numbers are:" + sum);


            Console.ReadKey();
        }
    }
}