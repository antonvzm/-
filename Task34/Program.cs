// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
        if (i < array.Length - 1) 
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int[] MultiplicationNumber(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size = size + 1;
    int[] newArray = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 -i];
    }
    if (array.Length % 2 == 1) newArray[newArray.Length - 1] = array[array.Length/2];
    return newArray; 
}

int[] massiv = CreateMassiv(6, 1, 9);
PrintMassiv(massiv);
Console.Write(" -> ");
int[] newMassiv = MultiplicationNumber(massiv);
PrintMassiv(newMassiv);


