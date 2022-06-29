/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

void palindrom(int n) // способ через string
{
    if (n < 0) n = n * -1;

    if (n < 10000 || n > 99999)
    {
        Console.Write("Некорректный ввод!");
        return;
    }

    string b = Convert.ToString(n);
    if (b[0] == b[4] && b[1] == b[3]) Console.WriteLine("Число " + n + " - палиндром");
    else Console.WriteLine("Число " + n + " - НЕ палиндром");
}

Console.Write("введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
palindrom(a);





/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void size(double ax, double ay, double az, double bx, double by, double bz)
{
    double ad = bz - az;
    double dc = bx - ax;
    double bc = by - ay;

    double c = ad * ad + dc * dc + bc * bc;
    double e = Math.Sqrt(c);

    Console.WriteLine("длина отрезка: " + e);
}

Console.Write("введите ax: ");
double pointax = Convert.ToDouble(Console.ReadLine());
Console.Write("введите ay: ");
double pointay = Convert.ToDouble(Console.ReadLine());
Console.Write("введите az: ");
double pointaz = Convert.ToDouble(Console.ReadLine());
Console.Write("введите bx: ");
double pointbx = Convert.ToDouble(Console.ReadLine());
Console.Write("введите by: ");
double pointby = Convert.ToDouble(Console.ReadLine());
Console.Write("введите bz: ");
double pointbz = Convert.ToDouble(Console.ReadLine());

size(pointax, pointay, pointaz, pointbx, pointby, pointbz);





/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void kub(int n)
{
    if (n < 0) n = n * -1;
    int a = 1;
    while (a <= n)
    {
        double b = Math.Pow(a, 3);
        Console.Write(b + ", ");
        a++;
    }
}

Console.Write("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
kub(a);
