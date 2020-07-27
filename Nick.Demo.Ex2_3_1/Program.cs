using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex2_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "女友生氣的樣子";
            int cp = 218;
            double weight = 61.34;
            double height = 1.54;

            Console.WriteLine($"寶可夢姓名：{name}\n" +
                              $"cp:{cp}\n"+
                              $"身高：{height}\n"+
                              $"體重：{weight}\n");

            Console.ReadKey();
        }
    }
}
