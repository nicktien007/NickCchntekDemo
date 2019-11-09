using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex4_3
{
    /// <summary>
    /// 範例4-3，if...else if... else…
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 59;

            if (grade >= 90)
            {
                Console.WriteLine("等第成積：A+");
            }
            else if (grade >= 80 && grade < 90)
            {
                Console.WriteLine("等第成積：A");
            }
            else if (grade >= 70 && grade < 80)
            {
                Console.WriteLine("等第成積：B+");
            }
            else if(grade >= 60 && grade < 70)
            {
                Console.WriteLine("等第成積：B");
            }
            else
            {
                Console.WriteLine("等第成積：C");
            }
        }
    }
}
