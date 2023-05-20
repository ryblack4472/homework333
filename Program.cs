using System;
public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter '+' or '-' (or any other input to exit):");
            string operation = Console.ReadLine();
            if (operation != "+" && operation != "-")
            {
                Console.WriteLine("Invalid input. Exiting program.");
                break;
            }
            Console.WriteLine("Enter the number of rows (M) in the matrix:");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns 👎 in the matrix:");
            int N = Convert.ToInt32(Console.ReadLine());
            float[,] matrix1 = new float[M, N];
            float[,] matrix2 = new float[M, N];
            float[,] resultMatrix = new float[M, N];
            Console.WriteLine("Enter the values for matrix 1:");
            ReadMatrixValues(matrix1);
            Console.WriteLine("Enter the values for matrix 2:");
            ReadMatrixValues(matrix2);
            if (operation == "+")
            {
                resultMatrix = AddMatrices(matrix1, matrix2);
            }
            else if (operation == "-")
            {
                resultMatrix = SubtractMatrices(matrix1, matrix2);
            }
            Console.WriteLine("Result matrix:");
            PrintMatrix(resultMatrix);
        }
    }
    static void ReadMatrixValues(float[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine("Enter value for position [" + i + "," + j + "]:");
                matrix[i, j] = Convert.ToSingle(Console.ReadLine());
            }
        }
    }
    static float[,] AddMatrices(float[,] matrix1, float[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        float[,] resultMatrix = new float[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return resultMatrix;
    }
    static float[,] SubtractMatrices(float[,] matrix1, float[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        float[,] resultMatrix = new float[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return resultMatrix;
    }
    static void PrintMatrix(float[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
