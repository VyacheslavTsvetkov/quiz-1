// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Promt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int M = Promt("Введите число ОТ которого будет вестить подсчет суммы ");
Console.WriteLine();
int N = Promt("Введите число ДО которого будет вестить подсчет суммы ");
Console.WriteLine();
int Sum = 0;

if (ValidateNumber(M, N))
{
    PrintSumFromMToN(M, N);
    Console.WriteLine(Sum);
}
void PrintSumFromMToN(int LowerBound, int UpperBound)
{
    if (LowerBound != UpperBound + 1)
    {
        Sum += LowerBound;
        PrintSumFromMToN(LowerBound + 1, UpperBound);
    }
}

bool ValidateNumber(int value1, int value2)
{
    if (value1 <= 0 && value2 <= 0)
    {
        Console.WriteLine("Пожалуйста введите положительное число и не равное 0.. \n Попробуйте заново. ");
        return false;
    }
    return true;
}