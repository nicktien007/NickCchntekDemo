using System;

namespace Nick.Demo.Ex5_1_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string result = "";

            for (int i = 1; i <= 9; i++)
            {
                int calcResult = 1 * i;
                
                result += $"{1}*{i}={calcResult.ToString("00")} \n";
            }

            Console.Write(result);
            Console.ReadKey();
        }
    }
}