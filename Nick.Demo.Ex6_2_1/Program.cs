using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex6_2_1
{
    /// <summary>
    /// Ex6_2_1：練習2 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = 40;
            int b = 51;
            int c = 33;

            double average = CalcAverage(a, b, c);

            Console.WriteLine($"{a},{b},{c}，平均值:{average}");
        }

        public static double CalcAverage(int a, int b,int c)
        {
            return (double)(a + b + c) / 3;
        }
    }
}
