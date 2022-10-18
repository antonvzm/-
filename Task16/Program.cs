//Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

Console.WriteLine("Введите день недели: ");
int data = Convert.ToInt32(Console.ReadLine());

if (data > 7)
Console.WriteLine("День недели не может быть больше 7");
else if (data > 5)
Console.WriteLine("Выходной");
else if (data > 0)
Console.WriteLine("Будний день");
else
Console.WriteLine("День недели не может быть меньше 1");