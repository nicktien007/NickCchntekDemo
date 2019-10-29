using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex3_1
{
    /// <summary>
    /// 範例3-1，陣列
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //宣告一個整數陣列，長度為3
            int[] ages1 = new int[3];

            Console.WriteLine(ages1[9]);

            //宣告一個整數陣列，並且直接塞入18、26、33、78、69
            int[] ages2 = new int[] { 12, 26, 33, 78, 69 };

            //取得陣列長度
            int length = ages1.Length;
            

            //取得陣列資料
            int n1 = ages2[0]; //n1 = 12
            int n2 = ages2[1]; //n2 = 6
            int n3 = ages2[2]; //n3 = 33

            //設定陣列內容
            ages2[3] = 888;  //設定位置3的值內容，原本為78，設為888
            ages2[4] = 99;   //設定位置4的值內容，原本為69，設為99

            Console.ReadKey();
        }
    }
}
