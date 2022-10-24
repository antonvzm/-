Console.WriteLine("Введите координаты точки");
Console.Write("X:");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int Y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

int quarter = Quarter(X, Y);
string result = quarter > 0 
        ?  $"Указанная координата соответствует четверти -> {quarter}" 
        : "Введены некорректные координаты";

Console.WriteLine(result);