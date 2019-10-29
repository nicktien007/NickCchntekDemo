using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex3_1_1
{
    /// <summary>
    /// 練習3-1，陣列
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] pokemonIds = new int[] {4, 1, 7, 25, 44};
            string[] pokemonNames = new[] {"小火龍", "妙蛙種子", "傑尼龜", "皮卡丘", "臭臭花"};

            Console.WriteLine("請輸入寶可夢索引：");

            string inputIndex = Console.ReadLine();
            int index = int.Parse(inputIndex ?? throw new InvalidOperationException());

            Console.WriteLine($"您輸入的寶可夢索引為：{index} / 寶可夢代號為：{pokemonIds[index]} / 寶可夢的名字：{pokemonNames[index]}");

            Console.ReadKey();
        }
    }
}
