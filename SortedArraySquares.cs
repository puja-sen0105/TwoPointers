using System;
using System.Collections.Generic;
using System.Text;

namespace TwoPointers
{
    class SortedArraySquares
    {
        public static int[] makeSquares(int[] arr)
        {
            int n = arr.Length;
            int[] squares = new int[n];
            int left = 0;
            int right = arr.Length - 1;
            int highestSquareIdx = n - 1;

            while (left <= right)
            {
                int leftSquare = arr[left] * arr[left];
                int rightSquare = arr[right] * arr[right];

                if (leftSquare > rightSquare)
                {
                    squares[highestSquareIdx--] = leftSquare;
                    left += 1;
                }
                else
                {
                    squares[highestSquareIdx--] = rightSquare;
                    right -= 1;
                }
            }

            return squares;
        }
    }
}
