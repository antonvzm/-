//Напишите программу, которая на вход
//принимает число (N), а на выходе показывает все чётные
//числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
int count = 0;
while (count <= number)
{
    int count2 = count % 2;
    if (count2 == 0 )
    {
        Console.Write($"{count}");
    }
    count++;
}
}
else Console.WriteLine("Введите число больше 0");