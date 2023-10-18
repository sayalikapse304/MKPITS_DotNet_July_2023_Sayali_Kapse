using System;


namespace program
{
    class natural
    {
        public static void Main()
        {

            int num=0;
            int sum = 0;
            float avr;
            while (num <= 10)
            {
                sum = sum + num;

               
                num++;
            }
            avr = sum / 10.0f;
            Console.WriteLine("sum:" + sum);
            Console.WriteLine("avr:" + avr);



            Console.ReadKey();
        }
    }
}