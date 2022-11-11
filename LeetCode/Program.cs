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
            Console.WriteLine(findMedianSortedArraysS.FindMedianSortedArrays(new int[] { 1, 1 }, new int[] {1, 2})); 
        }
    }
}
