using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex7_1_OPP_2
{
    /// <summary>
    /// Ex7_1 - OPP版本2 - 進行方法的抽取
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Nick===========");

            string nickName = "Nick";
            成為業務(nickName);
            溝通(nickName);
            獲得客戶的訂單(nickName);
            下訂單(nickName);
            指點同事(nickName);

            Console.WriteLine("\n==========小明===========");

            string nick的同事 = "小明";
            成為業務(nick的同事);
            溝通(nick的同事);
            獲得客戶的訂單(nick的同事);
            下訂單(nick的同事);

            Console.WriteLine("\n==========小Nick==========");

            string nick兒子 = "小nick";
            成為業務(nick兒子); //這邊，無法傳達是「子承父業」，還是小nick自己學習成為業務的
            溝通(nick兒子);
            獲得客戶的訂單(nick兒子);
            下訂單(nick兒子);
            指點同事(nick兒子);

            Console.ReadKey();

            //這個版本進行「函數」的抽取，將重復的代碼封裝成函數，
            //藉由傳入對象的不同，產生不同的行為
            //但是，如果新增一個同事，「獲得客戶的訂單」函數就需要新增一個if...else
            //50個同事，就需要新增50個判斷，大量的if..else，將會造成維護上的困難

            //「指點同事」該函數，只有「Nick」和「小nick」可以調用，未來如果有其它同事也需要調用
            //是不是需要調整「指點同事」裡面的if...else判斷

            //「溝通、下訂單、獲得客戶的訂單、成為業務、指點同事」 這些儘儘只是行為，無法做進一步的歸納
            //它們是相對凌亂的概念，彼此間的關系，無法明確定義它
        }

        static void 溝通(string name)
        {
            Console.WriteLine($"{name}跟客戶溝通");
        }

        static void 下訂單(string name)
        {
            Console.WriteLine($"{name}下訂單");
        }

        static void 成為業務(string name)
        {
            //這邊只能說明誰成為業務
            Console.WriteLine($"{name}成為一名業務");
        }

        static void 獲得客戶的訂單(string name)
        {
            //每個業務人員有自己「獲得客戶的訂單」的方法

            if (name == "Nick")
            {
                Console.WriteLine($"{name}使用研發多年的心法取得客戶訂單!!");
            }
            else if (name == "小明")
            {
                Console.WriteLine($"{name}使用從Nick那邊學到的一點技巧，" +
                                  "然後看書研發自己一套獲得訂單方式取得客戶訂單");
            }
            else if (name == "小nick")
            {
                Console.WriteLine($"{name}使用研發多年的心法取得客戶訂單!!");
            }
        }

        static void 指點同事(string name)
        {
            //指點同事只有 Nick 和 小Nick 會

            if (name == "Nick" || name == "小nick")
            {
                Console.WriteLine($"{name}傳授一點點心法加一些些誤導指點同事");
            }
        }
    }
}
