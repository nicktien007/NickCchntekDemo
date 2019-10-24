using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex2_1
{
    /// <summary>
    /// 範例2-1，基本輸入/輸出
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入您的名字：");

            string name = Console.ReadLine();

            Console.WriteLine("安安！！" + name + "歡迎回來");
        }
    }
}
