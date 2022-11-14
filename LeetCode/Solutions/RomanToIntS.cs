using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class RomanToIntS
    {
        public int RomanToInt(string s)
        {
            char[] chars = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int[] charsValue = { 1, 5, 10, 50, 100, 500, 1000 };
            string result = string.Empty;
            
            for (int i = 0; i < s.Length; i++)
                for (int j = 0; j < chars.Length; j++)
                    if (s[i] == chars[j])
                        

            Console.WriteLine(result);
            return 0;
        }

        public int RomanToInt1(string s)
        {
            int result = 0;

            var romans = new Dictionary<char, int>()
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };

            for (int i = 1; i < s.Length; i++)
            {
                foreach (var item in romans)
                {
                    if (s[i] == item.Key)
                    {
                        if (s[i-1] < s[i])
                        {
                            result += item.Value; 
                        }
                        else if(s[i - 1] > s[i])
                        {
                            result -= item.Value;
                        }
                        else
                        {
                            result += item.Value;
                        }
                    }
                }
            }
            return result;
        }
    }
}

