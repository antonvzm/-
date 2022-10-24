// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число");
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
void qube(int n)
{
    if (n > 0)
    {
        for (int i = 1; i <= n; i++)
        {
            double sqI = Math.Pow(i, 3);
            Console.WriteLine($"{i} | {sqI}");
        }
    }
    else
    {
        Console.WriteLine("Значение должно быть < 0");
    }
    }
Console.WriteLine($"{N} -> ");
qube(N);