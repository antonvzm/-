// Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number / 100;
int num2 = (number - (num1 * 100))/10;
if (number < 100 || number > 999)
Console.WriteLine("Число не трехзначное");
else
Console.WriteLine(num2);
