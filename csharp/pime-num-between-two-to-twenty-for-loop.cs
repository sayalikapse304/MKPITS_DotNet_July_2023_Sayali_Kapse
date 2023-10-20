using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace program
{
    class natural
    {


        public static void Main()
        {
            int flag = 0;
            for (int num = 2; num <= 20; num++)
            {
                flag = 0;
                for (int cnt = 2; cnt < num; cnt++)
                {
                    if (num % 2 == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("prime num:{0}", +num);
                }
            }
                Console.ReadKey();
            }
        }
    }
 


                   
                