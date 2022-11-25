// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите натуральное число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int Exponation(int numA, int numB)
{
if (numB == 0) return 1;
return numA * Exponation(numA, numB-1);
}

while (numB<0)
{
Console.WriteLine($"Введено отрицательное число!");
Console.Write("Введите натуральное число B: ");
numB = Convert.ToInt32(Console.ReadLine());
}

int exponation = Exponation(numA, numB);
Console.WriteLine($"возводит число {numA} в целую степень {numB} с помощью рекурсии -> {exponation}");