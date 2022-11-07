// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.Write("Введите первое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// int numStep = numA;
// for (int i = 0; i + 1 < numB; i++)
// {
//     numA = numA*numStep;
// }
// Console.WriteLine(numA);

Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

int NumStep(int a, int b)
{
int numStep = a;
    for (int i = 0; i + 1 < numB; i++)
{
    a = a*numStep;  
}

    return a;
}

    if (numB <= 0)
Console.WriteLine("Второе число должно быть натуральным");
    else
Console.WriteLine($"{numA},{numB} -> {NumStep(numA,numB)}");