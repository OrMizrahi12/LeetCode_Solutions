using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class RemoveElementS
    {
        public int RemoveElement(int[] nums, int val)
        {
            int c = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[c++] = nums[i];
                }
            }

            for (int i = c; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            return c;
        }
    }
}
