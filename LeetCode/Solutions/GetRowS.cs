using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class GetRowS
    {
        public IList<int> GetRow(int rowIndex)
        {
            IList<IList<int>> triangle = new List<IList<int>>();
            triangle.Add(new List<int> { 1 });

            for (int i = 0; i < rowIndex; i++)
            {
                int[] row = new int[triangle[i].Count + 1];
                row[0] = 1;

                for (int j = 1; j < triangle.Count; j++)
                    row[j] = triangle[i][j] + triangle[i][j - 1];

                row[triangle.Count] = 1;
                triangle.Add(row);
            }

            return triangle[triangle.Count - 1];
        }
    }
}
