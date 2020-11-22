namespace Exercises
{
    public class Factorial
    {
        // 0(n)
        public int FindFactorialRecursively(int number)
        {
            if (number == 2)
            {
                return 2;
            }
            return number * this.FindFactorialRecursively(number - 1);
        }


        // 0(n)
        public int FindFactorialIteratively(int number)
        {
            if (number == 2)
            {
                return 2;
            }

            int result = number;

            for (var i = number-1; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
