using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskam.pochivka
{
    public class smth
    {

        static int[] BalancedArray(int[] arr)
        {
            int n = arr.Length;
            int[] sortedArr = (int[])arr.Clone();
            Array.Sort(sortedArr);

            int[] result = new int[n];

            int left = 0;
            int right = n - 1;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    result[i] = sortedArr[left];
                    left++;
                }
                else
                {
                    result[i] = sortedArr[right];
                    right--;
                }
            }

            return result;

        }
    }
}
