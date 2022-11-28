using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class HammingWeightS
    {
        public int HammingWeight(uint n)
        {

            int result = 0;
            while (n != 0)
            {
                n &= (n - 1);
                result++;
            }
            return result;
        }
    }
}
