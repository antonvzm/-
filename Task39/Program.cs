// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool TheoremVerification(int number1, int number2, int number3)
{
    if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2)
    return true;
    else 
    return false;
}

Console.Write("Введите первую сторону треугольника: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите вторую сторону треугольника: ");
int num2 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите третью сторону треугольника: ");
int num3 = Convert.ToInt32 (Console.ReadLine());

if (TheoremVerification(num1, num2, num3) == true)
Console.WriteLine($"Треугольник со сторонами {num1}, {num2}, {num3} может существовать");
else Console.WriteLine($"Треугольник со сторонами {num1}, {num2}, {num3} не может существовать");