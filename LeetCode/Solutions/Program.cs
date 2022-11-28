using LeetCode.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HammingWeightS hammingWeightS = new HammingWeightS();
          hammingWeightS.HammingWeight(00000000000000000000000000001011);
            uint i = 00000000000000000000000000001011;

            Console.WriteLine(i &= i - 1);

        }
    }
}
