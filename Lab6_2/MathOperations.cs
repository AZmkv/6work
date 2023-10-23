namespace Lab6_2
{
    public class MathOperations
    {
        // Add methods
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        // Subtract methods
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Subtract(params int[] numbers)
        {
            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }

        // Multiply methods
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Multiply(params int[] numbers)
        {
            int result = 1;
            foreach (int num in numbers)
            {
                result *= num;
            }
            return result;
        }
    }
}
