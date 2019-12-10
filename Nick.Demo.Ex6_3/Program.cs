using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex6_3
{
    /// <summary>
    /// 範例6_3
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            皮卡丘 皮卡皮卡 = new 皮卡丘();

            皮卡皮卡.膚色 = "黃色";
            皮卡皮卡.分類 = "電氣鼠";
            皮卡皮卡.編號 = "25號";

            皮卡皮卡.招手();
            皮卡皮卡.吃();

            Console.WriteLine($"皮卡皮卡的膚色:{皮卡皮卡.膚色}");
            Console.WriteLine($"皮卡皮卡的編號:{皮卡皮卡.編號}");
            Console.WriteLine($"皮卡皮卡的分類:{皮卡皮卡.分類}");

            Console.WriteLine();
        }

        public class 皮卡丘
        {
            public string 膚色 { get; set; }
            public string 分類 { get; set; }
            public string 編號 { get; set; }

            public void 跳()
            {
                Console.WriteLine("皮卡丘跳起來!!");
            }

            public void 吃()
            {
                Console.WriteLine("皮卡丘吃果實!!");
            }

            public void 招手()
            {
                Console.WriteLine("皮卡丘向你招手!!");
            }
        }
    }
}
