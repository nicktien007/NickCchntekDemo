using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex3_1_2
{
    /// <summary>
    /// 練習3-2，陣列
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] pokemon1Ids = new int[] {54, 25, 44};
            string[] pokemonName1s = new[] {"可達鴨", "皮卡丘", "臭臭花"};

            int[] pokemon2Ids = new int[] { 38, 18, 40 };
            string[] pokemonName2s = new[] { "九尾", "比比鳥", "胖丁" };

            Console.WriteLine("請輸入小智要出戰的寶可夢位置：");
            string inputIndex1 = Console.ReadLine();
            int index1 = int.Parse(inputIndex1 ?? throw new InvalidOperationException());

            Console.WriteLine("請輸入小明要出戰的寶可夢位置：");
            string inputIndex2 = Console.ReadLine();
            int index2 = int.Parse(inputIndex2 ?? throw new InvalidOperationException());

            Console.WriteLine($"小智的寶可夢【{pokemonName1s[index1]}】(編號：{pokemon1Ids[index1]})" +
                              $"與小明的寶可夢【{pokemonName2s[index2]}】(編號：{pokemon2Ids[index2]})進行對戰!!");

            Console.ReadKey();
        }
    }
}
