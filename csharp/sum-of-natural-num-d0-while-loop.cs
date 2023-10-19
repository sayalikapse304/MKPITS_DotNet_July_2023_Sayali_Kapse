using System;


namespace program
{
    class natural
    {
        public static void Main()
        {

            int num = 1;
            int sum = 0;
            do
            {
                sum = sum + num;
                Console.WriteLine("natural num:" + num);
                num++;
            }
            while (num <= 10);

            Console.WriteLine("sum of natural numbers are:" + sum);


            Console.ReadKey();
        }
    }
}