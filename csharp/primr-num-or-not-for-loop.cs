using System;


namespace program
{
    class number
    {
        public static void Main()
        {
            int num;
            int cnt;
            int rem = 0;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());

            for (cnt = 2; cnt < num; cnt++)
            {
                rem = num % cnt;
                if (rem == 0)
                {
                    Console.WriteLine("not a prime number");
                    break;
                    cnt = 1;
                }
                
            }
                if (num == cnt)
                {
                    Console.WriteLine("It is a prime number");
                }
            
            Console.ReadKey();
        }
    }
}
            
