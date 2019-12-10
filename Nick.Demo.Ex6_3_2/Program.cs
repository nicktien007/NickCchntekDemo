using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex6_3_2
{
    /// <summary>
    /// 6_3_2：練習2
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            皮卡丘 皮卡丘1 = new 皮卡丘();
            皮卡丘1.姓名 = "1號皮卡丘";
            皮卡丘1.膚色 = "深黃色";
            皮卡丘1.分類 = "電氣鼠";
            皮卡丘1.編號 = "25號";

            皮卡丘 皮卡丘2 = new 皮卡丘();
            皮卡丘2.姓名 = "2號皮卡丘";
            皮卡丘2.膚色 = "黃色";
            皮卡丘2.分類 = "電氣鼠";
            皮卡丘2.編號 = "25號";

            Console.WriteLine($"姓名:{皮卡丘1.姓名},膚色:{皮卡丘1.膚色}");
            Console.WriteLine($"姓名:{皮卡丘2.姓名},膚色:{皮卡丘2.膚色}");

            Console.WriteLine();

            皮卡丘1.甩尾();
            皮卡丘2.跳();

            Console.ReadKey();
        }

        public class 皮卡丘
        {
            public string 姓名 { get; set; }
            public string 膚色 { get; set; }
            public string 分類 { get; set; }
            public string 編號 { get; set; }

            public void 跳()
            {
                Console.WriteLine($"{姓名}跳起來!!");
            }
            public void 甩尾()
            {
                Console.WriteLine($"{姓名}甩尾!!");
            }

            public void 吃()
            {
                Console.WriteLine($"{姓名}吃果實!!");
            }

            public void 招手()
            {
                Console.WriteLine($"{姓名}向你招手!!");
            }
        }
    }
}
