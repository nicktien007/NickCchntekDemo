using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex4_4
{
    /// <summary>
    /// 範例4-4，switch case
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int days = 5;

            switch (days)
            {
                case 1://星期一
                    Console.WriteLine("星期一，猴子穿新衣");
                    break;
                case 2://星期二
                    Console.WriteLine("星期二，猴子肚子餓");
                    break;
                case 3://星期三
                    Console.WriteLine("星期三，猴子去爬山");
                    break;
                case 4://星期四
                    Console.WriteLine("星期四，猴子看電視");
                    break;
                case 5://星期五
                    Console.WriteLine("星期五，猴子去跳舞");
                    break;
                case 6://星期六
                    Console.WriteLine("星期六，猴子去斗六");
                    break;
                case 0://星期日
                    Console.WriteLine("星期日，猴子過生日");
                    break;
                default:
                    Console.WriteLine("混混噩噩，今天星期幾？猴子不知道幹嘛~!!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
