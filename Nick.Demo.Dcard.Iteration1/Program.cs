using System;

namespace Nick.Demo.Dcard.Iteration1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("請輸入Dcard討論區代碼以進行爬蟲 \n" +
                              "1：感情,2：女孩,3：心情,4：有趣,5：美妝\n" +
                              "6：追星,7：穿搭,8：時事,9：美食,10：工作\n");

            string code = Console.ReadLine();
            var typeCode = int.Parse(code);

            Console.WriteLine($"\n您輸入的代碼為：{code},討論區為：{(ForumType)typeCode}，即將為你進行爬蟲~~~");

            Console.Read();
        }
    }
}