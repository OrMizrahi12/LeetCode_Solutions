using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class LongestCommonPrefixS
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int x = 0, doplication = 0;
            string result = string.Empty;
           
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                    if (strs[j].Length > i)
                        if (strs[0][x] == strs[j][x])
                            doplication++;
                if (doplication == strs.Length -1)
                {
                    result += strs[0][x];
                    x++; 
                }
                doplication = 0;
            }
            return result;
        }
    }
}