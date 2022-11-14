using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class IsPalindromeS
    {
        public bool IsPalindrome(int x)
        {
            int digit, result = 0, copy = x;
            while (copy != 0)
            {
                digit = copy % 10;
                result = result * 10 + digit;
                copy /= 10;
            }
            if (result > int.MaxValue || result < int.MinValue)
                return false;
            return x == Math.Abs(result);
        }


    }
}
