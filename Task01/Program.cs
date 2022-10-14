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