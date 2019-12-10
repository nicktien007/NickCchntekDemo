using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex6_2
{
    /// <summary>
    /// 範例6_2
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Hello,World";
            string text2 = "Hello,Nick";

            Display(text1);
            Display(text2);
        }

        public static void Display(string text)
        {
            Console.WriteLine(text);
        }
    }
}
