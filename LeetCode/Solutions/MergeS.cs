using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class MergeS
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            Array.Resize(ref nums1, m + n);

            for (int i = m; i < nums1.Length; i++)
                nums1[i] = nums2[i -m];

            for (int i = 0; i < nums1.Length; i++)
                for (int j = 0; j < nums1.Length; j++)
                    if(nums1[i] < nums1[j])
                    {
                        int temp = nums1[i];
                        nums1[i] = nums1[j];
                        nums1[j] = temp;
                    }
        }
    }
}

