namespace Exercises
{
    public class InsertionSort
    {
        public int[] Sort(int[] array)
        {
            for (int i = 1; i < array.Length; ++i)
            {
                int temp = array[i];
                int j = i - 1;

                // Move elements of array[0..i-1] that are greater than temp value to one position ahead of their current position .
                // Eller sagt på en anden måde. Hvis temp value er mindre end forgående value så swap dem indtil vi enten har nået bunden (0) eller foregående value er mindre. 
                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j = j - 1; // træk fra så vi kigger på den næste nedad i rækken.
                }

                array[j + 1] = temp;
            }

            return array;
        }
    }
}
