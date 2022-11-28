using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class SubsetsWithDupS
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);

            IList<IList<int>> result = new List<IList<int>>()
            {
               new List<int>()
            };
            result.Add(nums);
            List<int> list = new List<int>() {1,2,4};


            foreach (var item in result)
            {
                CompareTwoLists(item, list);
            }

            return result;
        }

        public static void CompareTwoLists(IList<int> A, List<int> B)
        {
            int dup = 0;
            int ind = 0;
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < B.Count; j++)
                {
                    if(A[i] == B[j])
                    {
                        dup++;
                    }
                }
                if(dup >= 2)
                {
                    dup = 0;
                    ind++; 
                }
            }

            if(ind == A.Count)
            {
                Console.WriteLine("Dop");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
