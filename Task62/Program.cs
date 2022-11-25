//  Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.WriteLine("Введите 2 числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

void NaturNum(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m} ");
        NaturNum(m + 1, n);

    }

    if (m > n)
    {
        Console.Write($"{m} ");
        NaturNum(m - 1, n);
    }
    if (m == n)
    {
        Console.Write($"{m} ");
    }
}

NaturNum(number1, number2);