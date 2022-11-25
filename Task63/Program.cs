// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponation(int numA, int numB)
{
    if (numB == 0) return 1;
    return numA * Exponation(numA, numB - 1);
}

int result = Exponation(numberA, numberB);
Console.WriteLine($"число {numberA} в целую степень {numberB} => {result}");