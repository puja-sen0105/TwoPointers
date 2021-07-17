using System;
using System.Collections.Generic;
using System.Text;

namespace TwoPointers
{
    class Practice
    {
        public static int[] twosum(int[] arr, int targetsum)
        {
            int left = 0;
            int right = arr.Length - 1;
            int countSum = 0;

            while (left < right)
            {
                countSum = arr[left] + arr[right];

                if (countSum == targetsum)
                {
                    return new int[] { left, right };
                }

                if (countSum > targetsum)
                {
                    right -= 1;
                }
                else
                {
                    left += 1;
                }

            }

            return new int[] { -1, -1 };
        }

        public static int[] twosumwithdictionary(int[] arr, int targetSum)
        { 
            Dictionary<int, int> nums = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (nums.ContainsKey(targetSum - arr[i]))
                    return new int[] { nums[targetSum - arr[i]], i };
                else
                    nums.Add(arr[i], i); // put the number and its index in the map
            }
            return new int[] { -1, -1 }; // pair not found

        }

        public static int RemoveDuplicates(int[] arr)
        {
            int nextnonduplicate = 1;

            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[nextnonduplicate - 1] != arr[i])
                {
                    arr[nextnonduplicate] = arr[i];
                    nextnonduplicate += 1;
                }
            }

            return nextnonduplicate;
        }
    }
}
