//Задача 6: Напишите программу, которая на вход
//принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int number2 = number % 2;

if (number2 > 0)
{
Console.WriteLine("Число не четное");
}
else
{
Console.WriteLine("Число четное");    
}