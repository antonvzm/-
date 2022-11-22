// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.


int[] CreateArray(int rows, int colums, int depth, int min, int max)
{
    int size = rows * colums * depth;
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max) + 1;
    }
    return array;
}

void SearchIdenticalNumber(int[] array, int min, int max)   // метод ищет одинаковое число, если найдет, то присваевает новое рандомное и сбрасывает счетчик занова
{
    int elem = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (elem == array[i])
            count++;
        else
        {
            elem = array[i];
            count = 1;
        }
        if (count > 1)
        {
            Random rnd = new Random();
            array[i] = rnd.Next(min, max + 1);
            i = 0;
            elem = array[0];
        }
    }
}


void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2))
                    Console.Write($"{matrix[i, j, k]} ({i},{j},{k})   ");
                else Console.Write($"{matrix[i, j, k]} ({i},{j},{k})   ");
            }
        }
        Console.WriteLine(" ");
    }
}

int[,,] ConvertArrayMatrix(int[] array, int rows, int colums, int depth)
{
    int count = 0;
    int[,,] matrix3D = new int[rows, colums, depth];
    for (int i = 0; i < matrix3D.GetLength(0); i++) // 2
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++) //
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = array[count];
                count++;
            }
        }
    }
    return matrix3D;
}

int rows = 2;
int colums = 2;
int depth = 2;
int min = 9;
int max = 99;

int[] array = CreateArray(rows, colums, depth, min, max);
SearchIdenticalNumber(array, min, max);

int[,,] matrix3D = ConvertArrayMatrix(array, rows, colums, depth);
PrintMatrix(matrix3D);