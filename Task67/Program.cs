// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int firstNum, int secondNum)
{
    if (firstNum == 0)
    {
        return secondNum + 1;

    }
    else if ((firstNum != 0) && (secondNum == 0))
    {
        return Akkerman(firstNum - 1, 1);
    }
    return Akkerman(firstNum - 1, Akkerman(firstNum, secondNum - 1));
}

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(Akkerman(firstNumber, secondNumber));