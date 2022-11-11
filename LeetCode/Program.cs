using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
          FindMedianSortedArraysS findMedianSortedArraysS = new FindMedianSortedArraysS();
            FindMaxKS findMaxKS = new FindMaxKS();
            Console.WriteLine(findMaxKS.FindMaxK(new int[] { 1, -1, 4, -4, 8 }));
        }
    }
}
