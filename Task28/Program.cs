//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNum(int x)
{
int numX = 0;
int sum = 0;

while (x > 0)

{
    numX = x % 10;
    sum = numX + sum;
    x = x / 10;  
}
return sum;
}

if (num < 0)
Console.WriteLine("Введите положительное число");
else
Console.WriteLine(SumNum(num));