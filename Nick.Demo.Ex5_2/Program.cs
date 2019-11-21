using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.Demo.Ex5_2
{
    /// <summary>
    /// 範例5-2，for迴圈
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //0-100，長度101
            int[] numbers = new int[101];

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = index;
            }
        }
    }
}
