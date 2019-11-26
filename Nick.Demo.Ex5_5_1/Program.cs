using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex5_5_1
{
    /// <summary>
    /// Ex5_5_1 練習2，do while 迴圈
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(1, 100);//隨機產生1~100的數字
            bool isGuessed = false;                      //該變數標記是否猜中
            int guessCount = 1;                          //紀錄猜測次數

            do
            {
                Console.Write("請輸入1~100：");

                string input = Console.ReadLine();
                int inputNumber = int.Parse(input);

                //判斷user輸入數字是否 【大於】 randomNumber
                if (inputNumber > randomNumber)
                {
                    Console.WriteLine($"第{guessCount}次，輸入的值太大了!!\n");
                }
                //判斷user輸入數字是否 【小於】 randomNumber
                else if (inputNumber < randomNumber)
                {
                    Console.WriteLine($"第{guessCount}次，輸入的值太小了!!\n");
                }
                else
                {
                    //user猜中，將isGuessed 標記為true，結束do while迴圈 
                    isGuessed = true;
                    Console.WriteLine($"恭喜你!!猜中了。總共猜{guessCount}次\n");
                }

                //user猜錯，猜測次數+1次
                guessCount++;

            } while (!isGuessed);
            //判斷user 是否猜中，如果猜錯(isGuessed == false)，繼續迴圈，猜對(isGuessed ==true)則跳離迴圈
        }
    }
}
