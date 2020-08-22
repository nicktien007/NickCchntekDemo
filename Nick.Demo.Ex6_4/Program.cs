using System;
using System.Text.Json;

namespace Nick.Demo.Ex6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();

            user1.Age = 28;
            user1.Name = "nick";
            
            Console.WriteLine($"user1.Age:{user1.Age}");
            Console.WriteLine($"user1.Name:{user1.Name}");
            Console.WriteLine();


            //將user1 進行序列化，轉換後的型別為：字串
            string user1_Serialize = JsonSerializer.Serialize(user1, new JsonSerializerOptions {WriteIndented = true});
            
            Console.WriteLine($"User1序列化：\n{user1_Serialize}\n");

            
            //將user1_Serialize 進行 反序列化，轉換後的型別為：User
            User user1_Deserialize = JsonSerializer.Deserialize<User>(user1_Serialize);
            
            Console.WriteLine("user1_Serialize 反序列化：");
            Console.WriteLine($"user1_Deserialize.Age:{user1_Deserialize.Age}");
            Console.WriteLine($"user1_Deserialize.Name:{user1_Deserialize.Name}");            

            Console.WriteLine();
        }

        public class User
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
    }
}