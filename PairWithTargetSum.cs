using System;
using System.Collections.Generic;
using System.Text;

namespace TwoPointers
{
    class PairWithTargetSum
    {
        public static int[] search(int[] arr, int targetSum)
        {

            Dictionary<int, int> nums = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (nums.ContainsKey(targetSum - arr[i]))
                {
                    return new int[] { nums[targetSum - arr[i]], arr[i] };
                }
                else
                {
                    nums.Add(arr[i], i);
                }
            }
            return new int[] { -1, -1 };
        }

        public static int[] searchWithoutDictionary(int[] arr, int targetSum)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int currentsum = arr[left] + arr[right];

                if (currentsum == targetSum)
                {
                    return new int[] { left, right };
                }



                if (currentsum < targetSum)
                {
                    left += 1;
                }
                else
                {
                    right -= 1;
                }
            }

            return new int[] { -1, -1 };
        }
    }
}
