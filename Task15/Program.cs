//Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей
//цифры нет.




Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());


while (number > 999)
{
    number = number / 10;
    
}
int num = number % 10;

if (number < 99)
Console.WriteLine($"У числа нет третьей цифры");
else
Console.WriteLine($"Третья цифра {num}");