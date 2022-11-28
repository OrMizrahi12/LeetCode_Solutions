using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class IsPowerOfTwoS
    {
        public bool IsPowerOfTwo(int n)
        {
            return Math.Log(n) % 1 == 0;
        }
    }
}
