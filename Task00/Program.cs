// Напишите программу, которая на вход
// 1.принимает число и выдаёт его квадрат (число
// 2.умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
Console.WriteLine("Этот код находит квадрат целого числа");
Console.Write("Введите целое число:  ");
int number = Convert.ToInt32 (Console.ReadLine());

//string str = Console.ReadLine();
//int num = Convert.ToInt32(str);

int square= number * number;
Console.WriteLine ($"Квадрат числа {number} = {square}");