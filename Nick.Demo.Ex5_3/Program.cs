using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex5_3
{
    /// <summary>
    /// 範例5-3，for迴圈
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            //起始值：2
            //執行條件：編號<=1000
            //變化方式：每次遞增2
            for (int nextNumber = 2; nextNumber <= 1000; nextNumber+=2)
            {
                //重複的動作
                total += nextNumber;
                //total = total + nextNumber;
            }

            Console.WriteLine(total);
        }
    }
}
