// Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int second = Convert.ToInt32(Console.ReadLine());
if (first > second)
{
    Console.Write($"{first} большее число, а {second} меньшее число ");
}
else if (first < second)
{
    Console.Write($"{second} большее число, а {first} меньшее число ");
}
else
{
    Console.Write("числа равны");
}