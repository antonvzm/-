// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.
// 9 2 3
// 4 2 4
// 2 6 7


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

int[,] ReversMatrix(int[,] matrix)
{
int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        newMatrix[i,j] = matrix[j, i]; 
    }
}
return newMatrix;
}

int[,] matrix = CreateMatrixRndInt(6 ,6 , 0, 9);
PrintMatrix(matrix);
if (matrix.GetLength(0) > matrix.GetLength(1) || matrix.GetLength(0) < matrix.GetLength(1))
Console.WriteLine("Строки и столбцы масива должны быть равны");
else
{
Console.WriteLine(" ");
int[,] newMatrix = ReversMatrix(matrix);
PrintMatrix(newMatrix);
}