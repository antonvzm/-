//11. Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого
//числа.
//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");

//int firstDigit = number / 100;
//int seconDigit = number % 10;
//Console.WriteLine($"Число {firstDigit}{seconDigit}");

int DelSecondDigit(int num)
{
    int firstDigit = num / 100;
    int seconDigit = num % 10;
    return firstDigit*10 + seconDigit;
}
int result = DelSecondDigit(number);
Console.WriteLine($"Полученое число {result}");

