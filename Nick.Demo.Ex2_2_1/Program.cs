using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex2_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入Dcard討論區代碼以進行爬蟲 => 1：感情版，2：美食，3：有趣");

            string code = Console.ReadLine();

            Console.WriteLine($"\n您輸入的代碼為：{code}，即將為你進行爬蟲~~~");

            Console.Read();
        }
    }
}
