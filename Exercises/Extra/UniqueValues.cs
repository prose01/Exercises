namespace Exercises
{
    public class UniqueValues
    {
        public int CountUniqueValues(int[] arr)
        {
            if (arr.Length == 0)
                return 0;

            int left = 0;
            int right = 1;

            while (right < arr.Length)
            {
                if (arr[left] != arr[right])
                {
                    left++;
                    arr[left] = arr[right];
                }

                right++;
            }

            return left + 1;
        }

        public int CountUniqueValues2(int[] arr)
        {
            if (arr.Length == 0)
                return 0;

            int left = 0;

            for (var right = 1; right < arr.Length; right++)
            {
                if (arr[left] != arr[right])
                {
                    left++;
                    arr[left] = arr[right];
                }
            }

            return left + 1;
        }
    }
}
