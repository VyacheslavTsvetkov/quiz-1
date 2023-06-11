// Напишите программу, которая принимает на вход три числа
//  и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int second = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int third = Convert.ToInt32(Console.ReadLine());
int max = first > second ? first : second;
max = max > third? max : third;
Console.Write($" максимальное число - {max} ");