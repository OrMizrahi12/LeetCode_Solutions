using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode.Solutions
{
    internal class MoveZeroesS
    {
        public void MoveZeroes(int[] nums)
        {
            int c = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[c++] = nums[i];
                }
            }

            for (int i = c; i < nums.Length; i++)
            {
                nums[i] = 0; 
            }
            

                      
        }
    }
}
