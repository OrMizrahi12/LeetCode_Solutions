using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountDistinctIntegersS countDistinctIntegersS = new CountDistinctIntegersS();
            Console.WriteLine(countDistinctIntegersS.CountDistinctIntegers(new int[] { 1, 13, 10, 12, 31 } ));
        }
    }
}
