namespace Exercises
{
    public class BinarySearch
    {
        // arr is sorted and non negative!


        public int LinearSearch(int[] arr, int lookup)  // Linear Search - 0(n)
        {
            if(arr.Length == 0)
            {
                return 0;
            }

            for(var i = 0; i < arr.Length; i++)
            {
                if(arr[i] == lookup)
                {
                    return i;
                }
            }

            return -1;
        }
        public int DivideAndConquer(int[] arr, int lookup)  // BinarySearch 0(log n)
        {
            if (arr.Length == 0)
            {
                return -1;
            }

            int min = 0;
            int max = arr.Length - 1;

            while(min <= max)
            {
                int middle = ((min + max) / 2);

                int currenItem = arr[middle];

                if(currenItem < lookup)
                {
                    min = middle + 1;
                }
                else if (currenItem > lookup)
                {
                    max = middle - 1;
                }
                else
                {
                    return middle;
                }
            }

            return -1;
        }
    }
}
