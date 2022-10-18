//14. Напишите программу, которая принимает на
//вход число и проверяет, кратно ли оно
//одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да
bool DivNum(int digit, int num1, int num2)
{
    int result1 = digit % num1;
    int result2 = digit % num2;
    if (result1 == 0 && result2 == 0) return true;
    return false;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

int number1 = 7;
int number2 = 23;

bool result = DivNum(number, number1, number2);
if (result)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("Не кратно");
}



//if (num1 > 0)
//Console.WriteLine($"{number} не кратно 7");
//else if (num2 > 0)
//Console.WriteLine($"{number} не кратно 23");
//else
//Console.WriteLine("Число кратно 7 и 23");