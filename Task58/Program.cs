// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max) + 1;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}   |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("   |");
    }
}

int[,] MultiplicationMatrix(int[,] matrix, int[,] secondMatrix)
{

    int[,] thirdMatrix = new int[matrix.GetLength(1), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            thirdMatrix[i,j] = default;
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
            thirdMatrix[i, j] += matrix[i,k] * secondMatrix[k,j];
            }

        }

    }
    return thirdMatrix;
}

int[,] matrix = CreateMatrixRndInt(3, 3, 0, 9);
PrintMatrix(matrix);
Console.WriteLine("----------------------------");
int[,] secondMatrix = CreateMatrixRndInt(3, 3, 0, 9);
PrintMatrix(secondMatrix);
Console.WriteLine("Произведение матриц: ");
int[,] thirdMatrix = MultiplicationMatrix(matrix, secondMatrix);
PrintMatrix(thirdMatrix);