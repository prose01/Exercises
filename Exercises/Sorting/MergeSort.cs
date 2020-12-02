using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class MergeSort
    {
        public int[] Sort(int[] array)
        {
            int[] result = new int[array.Length];

            //As this is a recursive algorithm, we need to have a base case to 
            //avoid an infinite recursion and therfore a stackoverflow
            if (array.Length <= 1)
            {
                return array;
            }

            // Spil array into two half. Take & Skip ensures there is no overlap.
            var left = array.Take(array.Length / 2).ToArray();
            var right = array.Skip(array.Length / 2).ToArray();

            //Recursively sort the left array
            left = Sort(left);
            //Recursively sort the right array
            right = Sort(right);

            //Merge our two sorted arrays
            result = Merge(left, right);

            return result;
        }

        private int[] Merge(int[] left, int[] right)
        {
            var mergedList = new List<int>();

            int indexLeft = 0;
            int indexRight = 0;

            while (indexLeft < left.Length || indexRight < right.Length)
            {
                // check if left and right are empty. If not compare them otherwise just add the new value.
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] < right[indexRight])
                    {
                        mergedList.Add(left[indexLeft]);
                        indexLeft++;
                    }
                    else
                    {
                        mergedList.Add(right[indexRight]);
                        indexRight++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    mergedList.Add(left[indexLeft]);
                    indexLeft++;
                }
                else if (indexRight < right.Length)
                {
                    mergedList.Add(right[indexRight]);
                    indexRight++;
                }
            }

            return mergedList.ToArray();
        }
    }
}
