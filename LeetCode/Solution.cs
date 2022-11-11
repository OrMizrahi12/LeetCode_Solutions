using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TwoSum
    {
        
        public void Send()
        {
            int[] nums = { 2, 7, 11, 15 };
            GetTwoSum(nums, 9);
        }
        public static int[] GetTwoSum(int[] nums, int target)
        {
            int[] arrResult;
            List<int> listResult = new List<int>();
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)           
                if (sum < target)
                {
                    sum += nums[i];
                    listResult.Add(i);
                }
            return arrResult = listResult.ToArray(); ;
        }
    }
}
