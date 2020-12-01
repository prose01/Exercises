namespace Exercises
{
    public class SelectionSort
    {
        // Not a very good sort Θ(n^2) but at least it does not use any extra space, O(1).
        public int[] Sort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                // Set current index as samllest.
                var tempIndex = i;
                var smallest = array[i];

                for (var n = i + 1; n < array.Length; n++)
                {
                    if (array[tempIndex] > array[n])
                    {
                        // Update samllest if current is  lower.
                        tempIndex = n;
                    }
                }

                array[i] = array[tempIndex];
                array[tempIndex] = smallest;
            }

            return array;
        }
    }
}
