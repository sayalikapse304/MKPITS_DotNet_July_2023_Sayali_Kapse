using System;


namespace program
{
    class cube
    {
        public static void Main()
        {
            int cnt = 1;
            int num;
            int res = 0;
            
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());

            while (cnt <= num)
            {
                res = cnt * cnt * cnt;

                Console.Write("Number is : {0} and cube of the {1} is :{2} \n", cnt, cnt,res);
                cnt++;
            }

            Console.ReadKey();
        }
    }
}






