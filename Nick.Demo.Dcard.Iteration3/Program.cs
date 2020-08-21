using System;
using System.Net;
using System.Net.Http;

namespace Nick.Demo.Dcard.Iteration3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("請輸入Dcard討論區代碼以進行爬蟲 \n" +
                              "1：感情,2：女孩,3：心情,4：有趣,5：美妝\n" +
                              "6：追星,7：穿搭,8：時事,9：美食,10：工作\n");

            string code = Console.ReadLine();
            var typeCode = int.Parse(code);

            Console.WriteLine("請輸入爬取筆數：");
            string limit = Console.ReadLine();
            
            Console.WriteLine($"\n您輸入的代碼為：{code},討論區為：{(ForumType)typeCode}，爬取筆數：{limit}，即將為你進行爬蟲~~~\n");

            
            //抽出一個方法，參數為typeCode(討論區代碼)，limit(爬取筆數)
            var jsonString = GetDcardList(typeCode, limit);

            Console.WriteLine($"爬到的內容為：{jsonString}");
            Console.Read();
        }

        private static string GetDcardList(int typeCode, string limit)
        {
            HttpClient httpClient = new HttpClient();

            //組裝討論區列表的網址
            string url = $"https://www.dcard.tw/service/api/v2/forums/" +
                         $"{(ForumType) typeCode}/posts" +
                         $"?popular=true" +
                         $"&limit={limit}";

            //發送請求並取得回應內容
            var response = httpClient.GetAsync(url).Result;

            //檢查回應的伺服器狀態StatusCode是否是200 OK
            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception("抓不到資料，請稍後再試!!");

            //讀取Content內容
            string jsonString = response.Content.ReadAsStringAsync().Result;
            return jsonString;
        }
    }
}