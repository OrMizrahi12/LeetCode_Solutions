using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class GenerateS
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> triangle = new List<IList<int>>();
            triangle.Add(new List<int> { 1 });
            
            for (int i = 0; i < numRows - 1 ; i++)
            {
                int[] row = new int[triangle[i].Count + 1];
                row[0] = 1;

                for (int j = 1; j < triangle.Count; j++)
                    row[j] = triangle[i][j] + triangle[i][j-1];

                row[triangle.Count] = 1;
                triangle.Add(row);
            }

            return triangle;
        }
    }
}
