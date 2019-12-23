using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex7_1_OPP
{
    /// <summary>
    /// Ex7_1 - OPP版本
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Nick===========");
            string nickName = "Nick";

            Console.WriteLine($"{nickName}跟客戶溝通");
            Console.WriteLine($"{nickName}使用研發多年的心法取得客戶訂單!!");
            Console.WriteLine($"{nickName}下訂單!!");
            Console.WriteLine($"{nickName}傳授一點點心法加一些些誤導指點同事");

            Console.WriteLine("\n==========小明===========");

            string nick的同事 = "小明";
            Console.WriteLine($"{nick的同事}跟客戶溝通");
            Console.WriteLine($"{nick的同事}使用從Nick那邊學到的一點技巧，" +
                              "然後看書研發自己一套獲得訂單方式取得客戶訂單");
            Console.WriteLine($"{nick的同事}下訂單!!");

            Console.WriteLine("\n==========小Nick==========");

            string nick兒子 = "小nick";
            Console.WriteLine($"{nick兒子}跟客戶溝通");
            Console.WriteLine($"{nick兒子}使用研發多年的心法取得客戶訂單!!");
            Console.WriteLine($"{nick兒子}下訂單!!");
            Console.WriteLine($"{nick兒子}傳授一點點心法加一些些誤導指點同事");

            //以上代碼沒有問題，但是…假設nick公司有50個業務

            //1.後續來了新同事「小華」、「小強」，那小明的那段代碼是不是又要重復撰寫兩次？
            //要加在哪裡，會不會加錯地方？

            //2.現在「業務」教育訓練流程新增了「實習」，
            //那以上的50處代碼是不是都要修改？，還要保證不能改錯

            //3.現在調用端要「小明」進行「三次溝通」再下訂單，是不是又會造成「溝通」代碼重復
            //就算複製貼上，也有可能貼錯…真的...

            //總之…維護及擴充上，都很困難
        }
    }
}
