//Напишите программу, которая принимает на вход координаты 
//двух тоек и находит расстояние между ними в 2D пространстве


// double d = 5.099459;
// double res = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(res);
// Math.Sqrt(45);

Console.WriteLine("Введите координаты первой точки");
Console.Write("X1:");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1:");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X2:");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2:");
int Y2 = Convert.ToInt32(Console.ReadLine());

double Range(int x11, int y11,int x21, int y21)
{
    int rangeX = x11 - x21;
    int rangeY = y11 - y21;
    double rangeZ = Math.Sqrt(rangeX * rangeX  + rangeY * rangeY);
    double res = Math.Round(rangeZ, 2, MidpointRounding.ToZero);
    return res;
}

double result = Range(X1, Y1, X2, Y2);
Console.WriteLine($"A:{X1},{Y1} B:{X2},{Y2} -> {result}");