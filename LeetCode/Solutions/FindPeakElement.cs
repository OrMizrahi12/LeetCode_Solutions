using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindPeakElementS
    {
        public int FindPeakElement(int[] nums)
        {

            int pick = 0;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] > nums[pick])         
                    pick = i;   
            return pick;
        }
    }
}
