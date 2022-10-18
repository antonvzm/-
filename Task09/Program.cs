//9. Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit) Console.WriteLine($"Наибольшее цифра числа равна {firstDigit}");
else Console.WriteLine($"Наибольшее цифра числа равна {secondDigit}");