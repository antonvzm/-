// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateMassiv(int size, int min, int max)
{
    int[] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max) + 1;
    }
    return array;
}

void PrintMassiv(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] massiv = CreateMassiv(123, 0, 123);
PrintMassiv(massiv);

int SearchNumber(int[] array, int min, int max)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > min && array[i] < max) 
        summ = summ + 1;
    }
    return summ;
}

Console.Write($"Чисел больше 10 и меньше 99 в массиве {SearchNumber(massiv, 10, 99)}");