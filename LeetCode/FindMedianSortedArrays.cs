using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindMedianSortedArraysS
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] arr = nums1.Concat(nums2).ToArray();
            int temp;

            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j]; 
                        arr[j] = temp;
                    }
                      
            if(arr.Length % 2 == 0)
                return  (arr[arr.Length/2 -1] + arr[arr.Length/2 ]) / 2.0; 
            else
                return  arr[arr.Length / 2];
        }
    }
}
