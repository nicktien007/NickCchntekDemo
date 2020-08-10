using System;

namespace Nick.Demo.Ex4_2_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("請輸入您的體重(公斤)");
            string weightStr = Console.ReadLine();

            Console.WriteLine("請輸入您的身高(公尺)");
            string heightStr = Console.ReadLine();

            //調用double.Parse 轉型
            double weight = double.Parse(weightStr);
            double height = double.Parse(heightStr);

            //BMI公式：BMI公式：體重[公斤] / 身高[公尺] * 身高[公尺]
            double BMI = weight / (height * height);

            string bmiStatus = "";
            
            //if...else...
            // if (BMI>=18.5 && BMI<25)
            // {
            //     bmiStatus = "體重正常";
            // }
            // else
            // {
            //     bmiStatus = "體重異常";
            // }

            //三元運算子
            bmiStatus = BMI >= 18.5 && BMI < 25 ? "體重正常" : "體重異常";
            
            Console.WriteLine($"您的BMI為：{BMI}，!!BMI狀態為：{bmiStatus}");
        }
    }
}