// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Lenth(double xa, double ya, double za, double xb, double yb, double zb)
{
    double lenth = Math.Sqrt((xb - xa) * (xb - xa ) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
    return lenth;
}
Console.Write("Введите значение координат x точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координат y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координат x точки А: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координат x точки В: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координат y точки В: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координат x точки В: ");
int zb = Convert.ToInt32(Console.ReadLine());

double lenth = Lenth(xa, ya, za, xb, yb, zb);
Console.WriteLine("Расстоянием между точками А и В равняется " + (lenth));