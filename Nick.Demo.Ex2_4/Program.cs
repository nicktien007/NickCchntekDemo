using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex2_4
{
    /// <summary>
    /// 範例2-4，運算子
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //算術運算子
            Console.WriteLine("========算術運算子========");
            int num1 = 30 + 20;
            int num2 = 30 - 20;
            int num3 = 3 * 20;
            int num4 = 30 / 3;
            int num5 = 20 % 3;

            Console.WriteLine($"【30 + 20】 = {num1}");
            Console.WriteLine($"【30 - 20】 = {num2}");
            Console.WriteLine($"【3 * 20】 = {num3}");
            Console.WriteLine($"【30 / 3】 = {num4}");
            Console.WriteLine($"【20 % 3】 = {num5}");

            //指定運算子，請觀察以下範例，a 值的變化
            Console.WriteLine("\n========指定運算子========");
            int a = 30;
            int b = 10;

            Console.WriteLine($"a = {a} , b = {b}");

            Console.WriteLine($"【a += b】 結果：{a += b}, 此時 a = {a} , b = {b}");
            Console.WriteLine($"【a -= b】 結果：{a -= b}, 此時 a = {a} , b = {b}");
            Console.WriteLine($"【a *= b】 結果：{a *= b}, 此時 a = {a} , b = {b}");
            Console.WriteLine($"【a /= b】 結果：{a /= b}, 此時 a = {a} , b = {b}");

            //遞增運算子
            Console.WriteLine("\n========遞增運算子========");

            int x = 8;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"【x++】 結果：{x++}, 此時 x = {x}");
            Console.WriteLine($"【x--】 結果：{x--}, 此時 x = {x}");
            Console.WriteLine($"【x--】 結果：{x--}, 此時 x = {x}");

            //比較運算子
            Console.WriteLine("\n========比較運算子========");

            int grade = 78;
            int passScore = 60;

            Console.WriteLine($"得分(grade)：{grade} , 及格分數(passScore)：{passScore}");
            Console.WriteLine($"【grade == passScore】 得分是否等於及格分數：{grade == passScore}");
            Console.WriteLine($"【grade > passScore】 得分是否大於及格分數：{grade > passScore}");
            Console.WriteLine($"【grade < passScore】 得分是否小於及格分數：{grade < passScore}");
            Console.WriteLine($"【grade >= passScore】 得分是否大於或等於及格分數：{grade >= passScore}");
            Console.WriteLine($"【grade <= passScore】 得分是否小於或等於及格分數：{grade <= passScore}");

            //邏輯運算子
            Console.WriteLine("\n========邏輯運算子========");

            int n1 = 123;
            int n2 = 48;
            int n3 = 589;
            int n4 = 300;

            Console.WriteLine($"n1 = {n1} , n2 = {n2} , n3 = {n3} ,n4 = {n4}");

            bool result1 = (n1 > n2) && (n3 > n4); //(n1 > n2)：True , (n3 > n4)：True
            bool result2 = (n1 < n2) || (n3 < n4); //(n1 < n2)：False , (n3 < n4)：False
            bool result3 = !(n4 > n3);             //(n4 > n3)：False，加上「!」，代表相反狀態

            Console.WriteLine($"【(n1 > n2) && (n3 > n4)】 = {result1}");
            Console.WriteLine($"【(n1 < n2) || (n3 < n4)】 = {result2}");
            Console.WriteLine($"【!(n4 > n3)】 = {result3}");
        }
    }
}
