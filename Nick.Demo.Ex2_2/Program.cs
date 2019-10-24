using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex2_2
{
    /// <summary>
    /// 範例2-2，文字模板
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入您的名字：");

            string name = Console.ReadLine();

            //舊版
            Console.WriteLine("安安！！{0}歡迎回來", name);

            //C# 6.0 - 新版
            //Console.WriteLine($"安安！！{name}歡迎回來");
        }
    }
}
