using System;


namespace program
{
    class cube
    {
        public static void Main()
        {
            int cnt = 0;
            int num ;
            int res = 0;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());

            do
            {
                cnt++;
            }
            while (cnt < num);
            res = cnt * cnt * cnt;
            Console.Write("Number is : {0} and cube of the {1} is :{2} \n", cnt, cnt, res);

            Console.ReadKey();
        }
    }
}






