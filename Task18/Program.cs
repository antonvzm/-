//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в это четверти (x и Y)

Console.WriteLine("Введите номер четверти");
int nomber = Convert.ToInt32(Console.ReadLine());

string Quarter (int x)
{
    if (x == 1) return  "x > 0 && y > 0";
    if (x == 2) return  "x < 0 && y > 0";
    if (x == 3) return  "x < 0 && y < 0";
    if (x == 4) return  "x > 0 && y < 0";
    return "Введен некоректный номер четверти";
}

string xy = Quarter(nomber);
Console.WriteLine($"{xy}");