using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class Solution
    {
        public static int[] InversePermutation(int[] arr, int n)
        {
            
            int[] result = new int[n];
            if (arr.Length != n) return Array.Empty<int>();
            
            // this solution also works 
            //for (int i = 0; i < n; i++)
            //{
            //    result[arr[i] - 1] = i + 1;
            //}
            

            arr.Where(x => x != 0).ToList().ForEach(x => result[x - 1] = arr.ToList().IndexOf(x) + 1);

            return result;
        }


    }
}
