//Решение в группах задач:
//12 мин
//16. Напишите программу, которая принимает на
//вход два числа и проверяет, является ли одно
//число квадратом другого.
//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8,9 -> нет

bool DigNum(int num1, int num2)
{
int numsqv1 = num1 * num1;
if (numsqv1 == num2) return true;
return false;
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32 (Console.ReadLine());

bool result = DigNum(number1, number2);
    if (result)
Console.WriteLine($"Число {number1} не является квадратом {number2}");
    else 
Console.WriteLine($"Число {number1} является квадратом {number2}");

bool result2 = DigNum(number2, number1);
    if (result2)
Console.WriteLine($"Число {number2} не является квадратом {number1}");
    else 
Console.WriteLine($"Число {number2} является квадратом {number1}");

