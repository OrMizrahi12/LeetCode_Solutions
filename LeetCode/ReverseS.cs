using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseS
    {
        public int Reverse(int x)
        {
                long result = 0, digit = 0;
                while (x != 0)
                {
                    digit = x % 10;
                    result = result * 10 + digit;
                    x /= 10;            
                }
                if (result > int.MaxValue || result < int.MinValue)
                return 0;
            return (int)result;
        }
    }
}
