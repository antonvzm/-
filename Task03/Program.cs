Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
int count = -number;
while (count <= number)
{
    Console.Write($"{count}");
    count++;
}
}
else Console.WriteLine("Введите положительное число");
