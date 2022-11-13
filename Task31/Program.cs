// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] CreateMassiv(int size, int min, int max)
{
    int[] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
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
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int[] ReversMassiv(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

int[] massiv = CreateMassiv(4, -10, 10);
PrintMassiv(massiv);
Console.Write("->");
ReversMassiv(massiv);
PrintMassiv(massiv);