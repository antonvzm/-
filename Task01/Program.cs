//Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//второго.
//a = 25; b = 5 -> да
//a = 10; b = 2 -> нет
//a = -3; b = 9 -> нет
//a = 9; b = -3 -> да

Console.Write("Введите цельное число: ");
    int number = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите квадрат этого числа: ");
    int square = Convert.ToInt32 (Console.ReadLine());

    if (number == square/number )
{
Console.WriteLine($"Квадрат {number} это {square}");

}

    else
{
Console.WriteLine($"Квадрат {number} не равен {square}");

}