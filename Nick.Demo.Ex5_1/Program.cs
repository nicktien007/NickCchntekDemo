using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex5_1
{
    /// <summary>
    /// 範例5-1，for迴圈
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //叫號機由8號開始叫號，初始值設定8
            for (int number = 8; number <= 22; number ++)
            {
                Console.WriteLine($"請{number}號患者進診間!!");   
            }
        }
    }
}
