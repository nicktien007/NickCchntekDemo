using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex2_3
{
    /// <summary>
    ///  範例2-3，型別
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //整數
            Console.WriteLine("==================整數==================");
            int number1 = 999;
            Console.WriteLine($"【int】 number1 是：{number1}");


            //超出整數值域範圍，報錯!
            //整數值域：-2147483648 至 2147483647
            //int number2 = 2147483648;
            //Console.WriteLine($"【number2】 是：{number2}");

            sbyte number3 = 125;
            Console.WriteLine($"【sbyte】 number3 是：{number3}");

            byte number4 = 253;
            Console.WriteLine($"【byte】 number4 是：{number4}");

            long number5 = 12345678955L;
            Console.WriteLine($"【long】 number5 是：{number5}");

            ulong number6 = 18446744073709551615;
            Console.WriteLine($"【ulong】 number6 是：{number6}");

            Console.WriteLine("\n==================浮點數==================");
            //浮點數
            float piFloat = 3.14159265359F;
            double piDouble = 3.14159265359;
            decimal piDecimal = 3.14159265359M;

            Console.WriteLine($"【float】 piFloat 是：{piFloat}");
            Console.WriteLine($"【double】 piDouble 是：{piDouble}");
            Console.WriteLine($"【decimal】 piDecimal 是：{piDecimal}");


            //字元及字串
            Console.WriteLine("\n==================字元及字串==================");

            char c = 'N';
            string str = "Hello Nick!!";

            Console.WriteLine($"【char】 c 是：{c}");
            Console.WriteLine($"【string】 str 是：{str}");

            //布林
            Console.WriteLine("\n==================布林==================");

            int age = 78;
            bool isHappy = false;
            bool isOlder = (age > 65);

            Console.WriteLine($"【bool】 isHappy 是：{isHappy.ToString()}");
            Console.WriteLine($"【bool】 isOlder 是：{isOlder.ToString()}");


            //型別轉換

            Console.WriteLine("\n==================型別轉換-數字轉換==================");
            //數字轉換
            //明確轉換
            Console.WriteLine("明確轉換");
            double d1 = 3.14159265359;
            Console.WriteLine($"d1={d1}");

            //float f1 = d1;      //隱含轉換(大資料轉小資料，不可隱含轉換)，報錯!!
            float f1 = (float)d1; //明確轉換(大資料轉小資料，精度損失)
            Console.WriteLine($"f1={f1}");

            //隱含轉換
            Console.WriteLine("\n隱含轉換");
            float f2 = 3.1415f;
            Console.WriteLine($"f2={f2}");

            double d2 = f2;         //隱含轉換
            double d3 = (double)f2; //明確轉換

            Console.WriteLine($"d2={d2}");
            Console.WriteLine($"d3={d3}");


            Console.WriteLine("\n文字轉數字");
            //文字轉數字
            string a = "70";
            string b = "30";

            Console.WriteLine($"【字串a】= {a}, 【字串b】 = {b}");
            Console.WriteLine($"【字串a】+【字串b】 = {a + b}");

            //將字串a、字串b，轉型數字
            Console.WriteLine("\n將字串a、字串b，轉型數字");
            int aParse = int.Parse(a);
            int bParse = int.Parse(b);

            Console.WriteLine($"【數字a】= {aParse}, 【數字b】 = {bParse}");
            Console.WriteLine($"【數字a】+【數字b】 = {aParse + bParse}");

            //文字轉數字，TryParse
            Console.WriteLine("\n文字轉數字，調用 TryParse");
            int aTryParse = 0;
            bool isSuccess = int.TryParse(a, out  aTryParse);
            if (isSuccess)
            {
                Console.WriteLine($"轉換成功，結果為{aTryParse}");
            }
            else
            {
                Console.WriteLine($"轉換失敗，請檢查資料來源");
            }


            Console.WriteLine("\n數字轉文字");
            //數字轉文字
            float pi = 3.14f;
            string piString = pi.ToString();

            Console.WriteLine($"【浮點數pi】= {pi}, 【字串pi】 = {piString}");
        }
    }
}
