using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex5_4
{
    /// <summary>
    /// 範例5-4，while 迴圈
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int n = 1;

            //當total小於100
            //把n和total相加，並指定給total
            //最後，將n的值加1
            while (total < 100)
            {
                total += n;
                n++;
            }

            Console.WriteLine($"total={total}");
            Console.WriteLine($"n={n}");

            Console.ReadKey();
        }
    }
}
