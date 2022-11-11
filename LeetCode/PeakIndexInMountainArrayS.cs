using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PeakIndexInMountainArrayS
    {
        public int PeakIndexInMountainArray(int[] arr)
        {
            int max = 0, headOfMountain = 0;
            bool MountainExsist = false;

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > max)
                {
                    max = arr[i];
                    headOfMountain = i;
                }
            
            for (int i = 0; i < arr.Length; i++)           
                if (i < headOfMountain && arr[i] < max || i > headOfMountain && arr[i] < max)
                    MountainExsist = true;
                else MountainExsist = false;

            return MountainExsist ? headOfMountain : -1;
        }
    }
}
