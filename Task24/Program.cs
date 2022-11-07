// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
    int sum= default;
    for (int i = 0; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.WriteLine($"Сумма чисел от 1 до {num} = {SumNumber(num)}");