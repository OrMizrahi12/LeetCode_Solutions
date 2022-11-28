using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class RemoveDuplicatesS
    {
        public int RemoveDuplicates(int[] nums)
        {
            List<int> sorted = new List<int>();
            for (int i = 0; i < nums.Length; i++)
                if (!sorted.Contains(nums[i]))
                    sorted.Add(nums[i]);      
            return sorted.Count;
        }
    }
}
