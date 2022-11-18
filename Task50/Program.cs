// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

int SearchElementMatrix(int[,] matrix, int rows, int colums)
{
    int number = matrix[rows, colums];
    return number;
}

int[,] matrix = CreateMatrixRndInt(6, 6, 0, 10);
PrintMatrix(matrix);

Console.WriteLine("Введите строку массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец массива: ");
int colums = Convert.ToInt32(Console.ReadLine());

if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1))
    Console.WriteLine($"{rows}, {colums} -> {SearchElementMatrix(matrix, rows, colums)}");
else
    Console.WriteLine($"{rows},{colums} -> такого элемента нет в массиве");
