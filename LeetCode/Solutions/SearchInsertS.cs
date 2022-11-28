using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class SearchInsertS
    {
        public int SearchInsert(int[] nums, int target)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    result = i;
                }
            }

            if(result == 0 && nums[0] != target)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < target)
                    {
                        result = i + 1;
                    }
                    
                }
            }
            return result; 
        }
    }
}
