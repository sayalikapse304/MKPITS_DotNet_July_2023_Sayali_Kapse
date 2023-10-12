using System;
namespace program
{
    class opration
    {

        public static void Main()
        {
            int num;
            int cnt;
            int result ;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for (cnt = 1; cnt <= 10; cnt++)
            {
                result = cnt * num;
                Console.WriteLine(+num + "*" + cnt + "=" + result);
            }
                Console.ReadKey();
            
        }
    }
}
