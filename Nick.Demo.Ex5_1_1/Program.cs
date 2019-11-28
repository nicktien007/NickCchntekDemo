using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex5_1_1
{
    /// <summary>
    /// Ex5_1_1 - 九九乘法表
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    result += $"{j}*{i}={(i * j).ToString("00")} ";
                }

                result += "\n";
            }

            Console.Write(result);
            Console.ReadKey();
        }
    }
}
