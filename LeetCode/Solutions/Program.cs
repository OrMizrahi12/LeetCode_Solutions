﻿using LeetCode.Solutions;
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
            LongestCommonPrefixS longestCommonPrefixS = new LongestCommonPrefixS();
            Console.WriteLine(longestCommonPrefixS.LongestCommonPrefix(new string[] {  "reflower", "flow", "flight" })); 
        }
    }
}