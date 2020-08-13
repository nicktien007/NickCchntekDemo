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
                result += $"{1}*{i}={(1 * i).ToString("00")} ";

                result += "\n";
            }

            Console.Write(result);
            Console.ReadKey();
        }
    }
}