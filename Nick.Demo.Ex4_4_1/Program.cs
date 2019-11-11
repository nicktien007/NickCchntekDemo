using System;

namespace Nick.Demo.Ex4_4_1
{
    /// <summary>
    /// Ex4_4_1：練習2
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string level = "A+";


            Console.WriteLine($"今年的績效考核為：{level}");

            switch (level)
            {
                case "A+":
                    Console.WriteLine("恭喜你!!今年度獎金 150% !!");
                    break;
                case "A":
                    Console.WriteLine("表現不錯喔!!今年度獎金 120% !!");
                    break;
                case "B+":
                    Console.WriteLine("感謝今年辛苦負出!!今年度獎金 100% !!");
                    break;
                case "B":
                    Console.WriteLine("加油!!今年度獎金 80% !!");
                    break;
                case "C":
                    Console.WriteLine("不好意思，今年公司營收不好，沒有獎金QQ~~");
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
