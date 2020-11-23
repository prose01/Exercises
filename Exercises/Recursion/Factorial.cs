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

        // 0(n)
        // Teacher's version.
        public int FindFactorialIteratively2(int number)
        {
            if (number == 2)
            {
                return 2;
            }

            int result = 1;

            for (var i = 2; i <= number; i++)
            {
                result = result * i;
            }

            return result;
        }


        // Recursion
        // A tail recursive function  https://www.geeksforgeeks.org/tail-recursion/
        // to calculate factorial 
        private int FactTR(int n, int a)
        {
            if (n == 0)
                return a;

            return FactTR(n - 1, n * a);
        }

        // A wrapper over factTR 
        public int Fact(int n)
        {
            return FactTR(n, 1);
        }
    }
}
