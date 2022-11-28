using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class CheckXMatrixS
    {
        public bool CheckXMatrix(int[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {
                    if (i == j || j == grid.Length - 1 - i)
                    {
                        if(grid[i][j] == 0)
                        {
                            return false;
                        } 
                    }
                    else if(grid[i][j] != 0)
                    {             
                        return false;
                    }
                }
            }
            return true; 
        }
    }
}
