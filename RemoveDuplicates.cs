using System;
using System.Collections.Generic;
using System.Text;

namespace TwoPointers
{
    class RemoveDuplicates
    {
        public static int remove(int[] arr)
        {
            int nextNonDuplicate = 1;// index of the next non-duplicate element

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[nextNonDuplicate - 1] != arr[i])
                {
                    arr[nextNonDuplicate] = arr[i];
                    nextNonDuplicate += 1;
                }
            }

            return nextNonDuplicate;
        }

        public static int[] subArrayRemoveDuplicateElements(int[] arr)
        {
            int nextNonDuplicate = 1;// index of the next non-duplicate element

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[nextNonDuplicate - 1] != arr[i])
                {
                    arr[nextNonDuplicate] = arr[i];
                    nextNonDuplicate += 1;
                }
            }

            return arr[0..nextNonDuplicate];
        }

        public static int[] RemoveKey(int[] arr,int key)
        {
            int nextElement = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != key)
                {
                    arr[nextElement] = arr[i];
                    nextElement += 1;
                }
            }

            return arr;
        }
    }
}
