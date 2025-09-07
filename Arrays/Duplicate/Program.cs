using System;
using System.Linq;
using System.Collections.Generic;
namespace Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrays = new int[7] { 4, 8, 9, 1, 2, 5, 4 };

            Dictionary<int, int> dictCount = new Dictionary<int, int>();

            for (int i = 0; i < arrays.Length; i++)
            {
                if (dictCount.ContainsKey(arrays[i]))
                {
                    dictCount[arrays[i]]++;
                }
                else
                {
                    dictCount[arrays[i]] = 1;
                }
            }

            var dupplicateNumbers = dictCount.Where(x => x.Value > 1).Select(x => x.Key).ToList<int>();
            Console.WriteLine(string.Join(", ", dupplicateNumbers));
        }
    }
}