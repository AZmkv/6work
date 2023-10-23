using System.Numerics;

class Program
{
    static void Main(double[,] rotationMatrix)
    {
        double[,] Matrix = new double[3, 3]
        {
            { 1, 0, 0 },
            { 0, 0, -1 },
            { 0, 1, 0 }
        };

        Console.WriteLine("Rotation Matrix:");
        PrintMatrix(rotationMatrix);

        Quaternion quaternion = Quaternion.FromMatrix(rotationMatrix);
        Console.WriteLine("\nQuaternion from Rotation Matrix:");
        Console.WriteLine(quaternion);

        double[,] newMatrix = quaternion.ToMatrix();
        Console.WriteLine("\nRotation Matrix from Quaternion:");
        PrintMatrix(newMatrix);

        Console.ReadKey();
    }

    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}