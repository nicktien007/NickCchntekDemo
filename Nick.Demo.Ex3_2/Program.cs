using System;
using System.Collections.Generic;

namespace Nick.Demo.Ex3_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            //宣告一個字串List，不指定初始值
            List<string> names1 = new List<string>();
            

            //宣告一個字串List，並且直接塞入"nick","penny","jack","joe"
            List<string> names2 = new List<string>() {"nick", "penny", "jack", "joe"};

            //取得List長度
            int length = names2.Count; //length = 4
            

            //取得List資料
            string name1 = names2[0]; //name1 = "nick"
            string name2 = names2[1]; //name2 = "penny"
            string name3 = names2[2]; //name3 = "jack"

            //設定List內容
            names2[1] = "Alice";  //設定位置1的值內容，原本為penny，設為Alice
            names2[3] = "Andy";   //設定位置3的值內容，原本為joe，設為Andy

            
            //List新增內容
            names2.Add("Bill"); //在變數names2新增資料"Bill"
            names2.Add("David");//在變數names2新增資料"David"
            
            Console.ReadKey();
        }
    }
}