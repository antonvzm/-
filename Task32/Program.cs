// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
bool SearchNumber(int num, int[] array)
{
    bool b = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            b = true;
            break;
        }
    }
    return b;
}


int[] massiv = CreateMassiv(4, 0, 10);
PrintMassiv(massiv);
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SearchNumber(number, massiv) ? "Да" : "Нет" );