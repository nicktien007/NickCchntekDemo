using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex4_1
{
    /// <summary>
    /// 範例4-1，if...else...
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double weight = 66;  //體重(公斤)
            double height = 1.75;//身高(公尺)
            double BMI = weight / (height * height); //BMI公式：體重[公斤] / 身高[公尺] * 身高[公尺]

            string status;  //健康狀態

            //如果BMI 大於等於 18.5 並且 小於等於25，健康狀態
            if (BMI >= 18.5 && BMI <= 25)
            {
                status = "(∩_∩) 不錯，你很健康喔";
            }
            else//否則異常狀態
            {
                status = "Σ( ° △ °|||) 你需要注意身體了";
            }

            Console.WriteLine($"BMI為：{BMI}");
            Console.WriteLine($"健康狀態為：{status}!!");
        }
    }
}
