using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class CheckValidS
    {
        public bool CheckValid(int[][] matrix)
        {

            if (matrix[0].Length != matrix.Length) return false;
            if (1 <= matrix.Length && matrix.Length <= 100)
            {
                for (int i = 0; i < matrix.Length; i++)
                    Array.Sort(matrix[i]);

                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix.Length; j++)
                    {
                        for (int k = 0; k < matrix.Length; k++)
                        {
                            if (matrix[i][k] > matrix.Length || matrix[j][k] > matrix.Length) return false;
                            if (matrix[j][i] != matrix[k][i])
                            {
                                return false;
                            }
                        }
                    }

                }
            }
            else return false;


            return true;
        }
       
       

    }
}
// { 1, 2, 3 },
// { 3, 1, 2 },
// { 2, 6, 1 },