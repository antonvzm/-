//12. Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли первое число
//кратным второму. Если число 1 не кратно числу 2, то
//программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32 (Console.ReadLine());

int digit = number1 % number2;
if (digit == 0) 
Console.WriteLine($"Число {number1} кратно {number2}");
else
Console.WriteLine($"Число {number1} не кратно {number2}, остаток {number1 % number2}");