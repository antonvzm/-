// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fibonachi(int num)
{
    Console.Write("0 1 ");
    int num1 = 0;
    int num2 = 1;
    int sum = default;
    for (int i = 0; i < num - 2; i++)
    {
        sum = num1 + num2;
        num1 = num2;
        num2 = sum;
        Console.Write($"{num2} ");
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Fibonachi(number);