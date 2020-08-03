using System;
using System.Collections.Generic;
using System.Linq;

namespace Nick.Demo.Ex3_2_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> pokemonIds = new List<int> {39, 37, 63, 143, 102};
            List<string> pokemonNames = new List<string> {"胖丁", "六尾", "凱西", "卡比獸", "蛋蛋"};

            Console.WriteLine("請輸入寶可夢索引：");

            string inputIndex = Console.ReadLine();
            int index = int.Parse(inputIndex ?? throw new InvalidOperationException());

            Console.WriteLine($"您輸入的寶可夢索引為：{index} / 寶可夢代號為：{pokemonIds[index]} / 寶可夢的名字：{pokemonNames[index]}");
            
            Console.ReadKey();
        }
    }
}