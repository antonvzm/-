// Задание
// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3






int[] CreateArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива с индексом {i}: ");
        array[i] = Convert.ToInt32 (Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int SearchZero(int[] array)
{
    int summ = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 0) 
        summ = summ + 1;
    }
    return summ;
}

Console.Write("Введите колличество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
    if (size < 1)
Console.WriteLine("Элементов массива не может быть меньше одного");
    else
{
int[] arr = CreateArray(size);
PrintArray(arr);
int sum = SearchZero(arr);
Console.WriteLine($"->{sum}");
}