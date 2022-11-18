// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1     4   8   19
// 5    -2  33   -2
// 77    3   8   1

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

void PrintMatrix(int[,] matrix)                                 // по столбцам
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

// void PrintMatrix(int[,] matrix)              по строкам
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
//             else Console.Write($"{matrix[i, j],5}");
//         }
//         Console.WriteLine(" |");
//   }
// }



int[,] matrix = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(matrix);

