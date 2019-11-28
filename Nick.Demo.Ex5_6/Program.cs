using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex5_6
{
    /// <summary>
    /// break / continue
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============調用 continue：=============");
            for (int i = 1; i <= 10; i++)
            {
                //i = 3，調用continue，continue之後的程式不會執行，繼續迴圈
                //只有 3 沒有印出來
                if (i == 3)
                {
                    continue;
                }

                Console.WriteLine(i);
            }


            Console.WriteLine("\n=============調用 break：=============");
            for (int i = 1; i <= 10; i++)
            {
                //i = 3，break，結束迴圈
                //只印出了「1」、「2」，因為i = 3，結束迴圈，後續不打印
                if (i == 3)
                {
                     break;
                }

                Console.WriteLine(i);
            }
        }
    }
}
