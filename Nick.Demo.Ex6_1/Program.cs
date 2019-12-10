using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex6_1
{
    /// <summary>
    /// 範例6_1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 5;

            int result = Sum(x, y);

            Console.WriteLine(result);
        }

        public static int Sum(int x,int y)
        {
            return x + y;
        }
    }
}
