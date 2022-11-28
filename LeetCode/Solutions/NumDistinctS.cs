using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class NumDistinctS
    {
        public int NumDistinct(string s, string t)
        {
            int[] options = new int[t.Length + 1]; // 4
            options[0] = 1;

            foreach (char c in s)
            {
                for (int i = t.Length; i > 0; i--)
                {
                    if (t[i - 1] == c)
                    {
                        options[i] += options[i - 1];
                    }      
                }
            }

            return options[t.Length];
       }
    }
}
