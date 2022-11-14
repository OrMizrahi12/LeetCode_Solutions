using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SubStringNoRepeat
    {
        public int LengthOfLongestSubstring(string s)
        {

            string test = ""; string result = "";

            foreach (char c in s.ToCharArray())
            {
                if (test.Contains(c))
                    test = test.Substring(test.IndexOf(c) + 1);
                test += c;
                if (result.Length < test.Length)
                    result = test;
            }
            Console.WriteLine(result);
            return result.Length;
        }


        
    } 
}

