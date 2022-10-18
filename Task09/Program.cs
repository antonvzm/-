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

//if (firstDigit > secondDigit) Console.WriteLine($"Наибольшее цифра числа равна {firstDigit}");
//else Console.WriteLine($"Наибольшее цифра числа равна {secondDigit}");

int result = default;
if(firstDigit > secondDigit) result = firstDigit;
else result = secondDigit;
Console.WriteLine($"Наибольшее цифра числа равна {secondDigit}");

// Тернарный оператор 1
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшее цифра числа равна {maxDigit}");

// Тернарный оператор 2
Console.Write($"Наибольшая цифра числа {number} равна ");
Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);


int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}