using System;

namespace TwoPointers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = PairWithTargetSum.search(new int[] { 1, 2, 3, 4, 6 },6); //[1, 3]
            int[] x1 = PairWithTargetSum.search(new int[] { 2, 5, 9, 11 }, 11);//[0, 2]

            int[] x2 = PairWithTargetSum.searchWithoutDictionary(new int[] { 1, 2, 3, 4, 6 }, 6); //[1, 3]
            int[] x3 = PairWithTargetSum.searchWithoutDictionary(new int[] { 2, 5, 9, 11 }, 11);//[0, 2]

            int x5 = RemoveDuplicates.remove(new int[] { 2, 3, 3, 3, 6, 9, 9 }); //4
            int[] x6 = RemoveDuplicates.subArrayRemoveDuplicateElements(new int[] { 2, 3, 3, 3, 6, 9, 9 });


            int x7 = RemoveDuplicates.remove(new int[] { 2, 2, 2, 11 }); //2
            int[] x8 = RemoveDuplicates.subArrayRemoveDuplicateElements(new int[] { 2, 2, 2, 11 });

            int[] x9 = Practice.twosum(new int[] { 1, 2, 3, 4, 6 }, 6); //[1, 3]
            int[] x99 = Practice.twosum(new int[] { 2, 5, 9, 11 }, 11);//[0, 2]

            int[] result = SortedArraySquares.makeSquares(new int[] { -2, -1, 0, 2, 3 });


            Console.ReadLine();
        }
    }
}
