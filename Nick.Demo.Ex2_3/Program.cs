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
        }
    }
}
