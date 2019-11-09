using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex4_2
{
    /// <summary>
    /// 範例4-2，三元運算子
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 80;
            string status;

            //一般if...else...
            //if (grade >= 60)
            //{
            //    status = "恭喜你，測驗通過!!";
            //}
            //else
            //{
            //    status = "加油，再接再厲!!";
            //}

            //三元運算子表示法
            status = grade >= 60 ? "恭喜你，測驗通過!!" : "加油，再接再厲!!";


            Console.WriteLine($"考試結果：{status}");
        }
    }
}
