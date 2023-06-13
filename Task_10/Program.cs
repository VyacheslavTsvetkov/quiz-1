// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int converted (int num)
{
    int result = (num - ((num / 100) * 100)) / 10;
    return result;
}

System.Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"число {number}, вторая цифра - {converted(number)}");