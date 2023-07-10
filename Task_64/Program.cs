// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Promt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int N = Promt("Введите число до которого (начиная с 1) будут \nвыводиться все натуральные числа.");
Console.WriteLine();

if (ValidateNumber(N))
{
    PrintNumbers(N);
}
void PrintNumbers(int UpperBound)
{
    if (UpperBound > 1)
    {
        Console.Write($"{UpperBound}, ");
        PrintNumbers(UpperBound - 1);
    }
    if (UpperBound == 1)
    {
        Console.Write($"{UpperBound}");
    }
}

bool ValidateNumber(int value)
{
    if (value <= 0)
    {
        Console.WriteLine("Пожалуйста введите положительное число и не равное 0.. \n Попробуйте заново. ");
        return false;
    }
    return true;
}