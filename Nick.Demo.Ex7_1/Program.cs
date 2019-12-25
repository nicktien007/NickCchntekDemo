using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex7_1
{
    /// <summary>
    /// Ex7_1 - 講故事，學OOP
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Nick===========");
            Nick nick = new Nick();
            nick.溝通();
            nick.獲得客戶的訂單();
            nick.下訂單();
            nick.指點同事();

            Console.WriteLine("\n==========小明===========");

            小明 nick同事小明 = new 小明();
            nick同事小明.溝通();
            nick同事小明.獲得客戶的訂單();
            nick同事小明.下訂單();

            Console.WriteLine("\n==========小Nick==========");

            小Nick 小nick = new 小Nick();
            小nick.溝通();
            小nick.獲得客戶的訂單();
            小nick.下訂單();
            小nick.指點同事();

            //吐苦水為父類別private方法，子類別也無法調用
            //小nick.吐苦水();



            Console.ReadKey();
        }
    }

    //採用封裝的技巧，將業務的行為，進行包裝
    //外界只看的到「溝通、獲得客戶的訂單、下訂單」三個行為
    //並不知道其實作細節
    public abstract class 業務
    {
        public void 溝通() => Console.WriteLine("跟客戶溝通");

        public abstract void 獲得客戶的訂單();

        public void 下訂單() => Console.WriteLine("下訂單");
    }

    public class Nick : 業務
    {
        public override void 獲得客戶的訂單()
        {
            Console.WriteLine("使用Nick研發多年的心法取得客戶訂單!!");
        }

        public void 指點同事() => Console.WriteLine("傳授一點點心法加一些些誤導指點同事!!");

        //抱怨同事及客戶不能對外公開，這是Nick私底下的事，所以使用「private」
        private void 吐苦水() => Console.WriteLine("Nick跟老婆抱怨同事及客戶!!");
    }

    /// <summary>
    /// Nick的同事
    /// </summary>
    public class 小明 : 業務
    {
        public override void 獲得客戶的訂單()
        {
            //從Nick那邊學到一點技巧
            Console.WriteLine("小明從Nick那邊學到一點技巧，" +
                              "然後看書研發自己一套獲得訂單方式");
        }
    }

    /// <summary>
    /// Nick 的小孩
    /// </summary>
    public class 小Nick : Nick
    {
        
    }
}
