// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
//  квадратов чисел от 1 до N.

Console.WriteLine("Введите число");
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
void Squar(int n)
{
    if (n > 0)
    {
        for (int i = 0; i <= n; i++)
        {
            int sqI = i * i;
            Console.Write($"{sqI}, ");
        }
    }
    else
    {
        Console.WriteLine("Значение должно быть < 0");
    }
    }

Squar(N);