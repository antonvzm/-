// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = 0;
        }
    }
    return matrix;
}




void CreateSpiral(int[,] matrix)
{
    int count = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 1)
            j = 2;
            if (matrix[i,j] == 0) 
            matrix[i,j] = count;
            count++;
        }
    }
}

void PrintSpiral(int[,] matrix)
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

int[,] spiral = CreateMatrix(4, 4);
CreateSpiral(spiral);
PrintSpiral(spiral);