// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = 0;
int count = 0;
int i = 1;

int OMG(int n)
{
while (i < 100000)                                  // count = N / 1 % 10 * 10000;
{                                                   // count = N / 10 % 10 * 1000;
    count = n / i % 10 * 10000 / i;                 // count = N / 100 % 10 * 100 ;    
    result = count + result;                        // count = N / 1000 % 10 *10;  // = 40        
    i = i * 10;                                     // count = N / 10000 % 10 * 1 ; //=5         
}
return result;
}
if (N < 10000 || N > 99999)
Console.WriteLine("Число не пятизначное");
else
{
int res = OMG(N);
if (res == N)
Console.WriteLine($"{N} -> да");
else
Console.WriteLine($"{N}->нет");
}