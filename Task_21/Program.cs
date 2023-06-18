// Напишите программу, которая принимает на вход координаты двух
//  точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double DistanceBetweenTwoPoints(int deltaX, int deltaY, int deltaZ)
{
    double result = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));
    return Math.Round(result, 2);
}

System.Console.WriteLine("Введите координату X точки A");
int A_x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки A");
int A_y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z точки A");
int A_z = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату X точки B");
int B_x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки B");
int B_y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z точки B");
int B_z = Convert.ToInt32(Console.ReadLine());
int delta_x = B_x - A_x;
int delta_y = B_y - A_y;
int delta_z = B_z - A_z;

Console.WriteLine($"координаты точки А - {A_x}, {A_y}, {A_z}");
Console.WriteLine($"координаты точки B - {B_x}, {B_y}, {B_z}");
Console.WriteLine($"Расстояние между точками А и В в трехмерном пространстве - {DistanceBetweenTwoPoints(delta_x, delta_y, delta_z)}");

