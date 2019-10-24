using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex2_5
{
    /// <summary>
    /// 範例2-5，邏輯運算子
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入需要進化的糖果數量(需要200個糖果才可以進化)：");
            string count = Console.ReadLine();

            //輸入的型別為string，調用int.Parse 轉型為 int
            int number = int.Parse(count ?? throw new InvalidOperationException());
            bool enabled = (number >= 200);

            Console.WriteLine($"進化開關的啟用狀態：{enabled}");
        }
    }
}
