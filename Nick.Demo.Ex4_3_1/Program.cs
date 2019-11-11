using System;

namespace Nick.Demo.Ex4_3_1
{
    /// <summary>
    /// Ex4_3_1：練習1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
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

            if (BMI < 15)
            {
                Console.WriteLine($"您的BMI為：{BMI}，非常嚴重的體重不足");
            }
            else if (BMI >= 15 && BMI < 16)
            {
                Console.WriteLine($"您的BMI為：{BMI}，嚴重體重不足");
            }
            else if (BMI >= 16 && BMI < 18.5)
            {
                Console.WriteLine($"您的BMI為：{BMI}，體重過輕");
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine($"您的BMI為：{BMI}，保持的很棒喔!!體重正常(健康體重)");
            }
            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine($"您的BMI為：{BMI}，體重過重");
            }
            else if (BMI >= 30 && BMI < 35)
            {
                Console.WriteLine($"您的BMI為：{BMI}，肥胖I級（中等肥胖）");
            }
            else if (BMI >= 35 && BMI < 40)
            {
                Console.WriteLine($"您的BMI為：{BMI}，肥胖II級（嚴重肥胖）");
            }
            else if (BMI >= 40)
            {
                Console.WriteLine($"您的BMI為：{BMI}，肥胖III級（非常嚴重肥胖）");
            }

            Console.ReadKey();
        }
    }
}
