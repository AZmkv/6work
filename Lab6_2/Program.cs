using Lab6_2;

class Program
{
    static void Main()
    {
        MathOperations math = new MathOperations();

        // Addition
        int sum1 = math.Add(5, 3);
        Console.WriteLine($"Sum of two numbers: {sum1}");

        int sum2 = math.Add(1, 2, 3, 4, 5);
        Console.WriteLine($"Sum of an array of numbers: {sum2}");

        // Subtraction
        int difference1 = math.Subtract(10, 3);
        Console.WriteLine($"Difference of two numbers: {difference1}");

        int difference2 = math.Subtract(10, 2, 3, 1);
        Console.WriteLine($"Difference of an array of numbers: {difference2}");

        // Multiplication
        int product1 = math.Multiply(2, 3);
        Console.WriteLine($"Product of two numbers: {product1}");

        int product2 = math.Multiply(2, 3, 4);
        Console.WriteLine($"Product of an array of numbers: {product2}");
    }
}
