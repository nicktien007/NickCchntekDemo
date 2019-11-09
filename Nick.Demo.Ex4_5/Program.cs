using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex4_5
{
    /// <summary>
    /// 範例4-5 ，enum 列舉
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Days days = Days.星期五;
            switch (days)
            {
                case Days.星期日:
                    Console.WriteLine("星期日，猴子過生日");
                    break;
                case Days.星期一:
                    Console.WriteLine("星期一，猴子穿新衣");
                    break;
                case Days.星期二:
                    Console.WriteLine("星期二，猴子肚子餓");
                    break;
                case Days.星期三:
                    Console.WriteLine("星期三，猴子去爬山");
                    break;
                case Days.星期四:
                    Console.WriteLine("星期四，猴子看電視");
                    break;
                case Days.星期五:
                    Console.WriteLine("星期五，猴子去跳舞");
                    break;
                case Days.星期六:
                    Console.WriteLine("星期六，猴子去斗六");
                    break;
                default:
                    Console.WriteLine("混混噩噩，今天星期幾？猴子不知道幹嘛~!!");
                    break;
            }

            Console.ReadKey();
        }
    }

    enum Days
    {
        星期日 = 0,
        星期一 = 1,
        星期二 = 2,
        星期三 = 3,
        星期四 = 4,
        星期五 = 5,
        星期六 = 6,
    }
}
