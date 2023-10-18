using System;


namespace program
{
    class natural
    {
        public static void Main()
        {

            int num = 0;
            int sum = 0;
            float avr;
            do
            {
                sum = sum + num;


                num++;
            }
            while (num <= 10);
            avr = sum / 10.0f;
            Console.WriteLine("sum:" + sum);
            Console.WriteLine("avr:" + avr);



            Console.ReadKey();
        }
    }
}