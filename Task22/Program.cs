// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
Console.Write("X1:");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1:");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1:");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X2:");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2:");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2:");
int Z2 = Convert.ToInt32(Console.ReadLine());

double Range(int x11, int y11, int z11,int x21, int y21, int z21)
{
    int rangeX = x11 - x21;
    int rangeY = y11 - y21;
    int rangeZ = z11 - z21;
    double rangez = Math.Sqrt(rangeX * rangeX  + rangeY * rangeY + rangeZ * rangeZ);
    double res = Math.Round(rangez, 2, MidpointRounding.ToZero);
    return res;
}

double result = Range(X1, Y1, Z1, X2, Y2, Z2);
Console.WriteLine($"A:{X1},{Y1},{Z1} B:{X2},{Y2},{Z2} -> {result}");