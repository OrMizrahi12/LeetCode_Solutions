using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CountDistinctIntegersS
    {
        public int CountDistinctIntegers(int[] nums)
        {
            int[] arrRevers = new int[nums.Length]; 
            for (int i = 0; i < nums.Length; i++)
                arrRevers[i] = reverstNumbers(nums[i]);

            return nums.Concat(arrRevers).ToArray().Distinct().ToArray().Length; 
        }

        static private int reverstNumbers(int number)
        {

            int result = 0, digit = 0;
            while (number != 0)
            {
                 digit = number % 10;
                 result = result * 10 + digit;
                 number /= 10;

            }
            return result;
        }
    }
}
