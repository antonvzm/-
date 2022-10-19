// Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
Console.WriteLine("Число не трехзначное");

else

 number = number / 10 % 10;

Console.WriteLine(number);
