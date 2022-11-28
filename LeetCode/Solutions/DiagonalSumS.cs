using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class DiagonalSumS
    {
        public int DiagonalSum(int[][] mat)
        {
            int result = 0;

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat.Length; j++)
                {
                    if (i == j || j == mat.Length - 1 - i)
                    {
                        result += mat[i][j];
                    }
                    else 
                    {
                        continue;
                    } 
                }
            }

            return result;
        }
    }
}
