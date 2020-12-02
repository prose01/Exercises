namespace Exercises
{
    public class BubbleSort
    {
        // Not a very good sort Θ(n^2) but at least it does not use any extra space, O(1).
        public int[] Sort(int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var n = 0; n < array.Length - 1; n++)
                {
                    if (array[n] > array[n + 1])
                    {
                        // Swap numbers
                        var temp = array[n];

                        array[n] = array[n + 1];
                        array[n + 1] = temp;
                    }
                }
            }

            return array;
        }

        public int[] SortDesc(int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var n = 0; n < array.Length - 1; n++)
                {
                    //Simply reverse the compare and you have a descending sort :)
                    if (array[n] < array[n + 1])
                    {
                        // Swap numbers
                        var temp = array[n];

                        array[n] = array[n + 1];
                        array[n + 1] = temp;
                    }
                }
            }

            return array;
        }
    }
}
