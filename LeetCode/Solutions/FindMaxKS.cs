using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindMaxKS
    {
        public int FindMaxK(int[] nums)
        {
            int max = -1;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] > max)
                    for (int j = 0; j < nums.Length; j++)
                        if (nums[i] + nums[j] == 0)
                            max = nums[i];
            return max;
        }
    }
}
