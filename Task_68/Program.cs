// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Promt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int m = Promt("Введите первое неотрицательное число ");
Console.WriteLine();
int n = Promt("Введите второе неотрицательное число ");
Console.WriteLine();
int AkkermanSum = 0;

if (ValidateNumber(m, n))
{
    AkkermanSum = AkkFunc(m, n);
    Console.WriteLine(AkkermanSum);
}

int AkkFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AkkFunc(m - 1, 1);
    }
    else
    {
        return AkkFunc(m - 1, AkkFunc(m, n - 1));
    }
}

bool ValidateNumber(int value1, int value2)
{
    if (value1 <= 0 && value2 <= 0)
    {
        Console.WriteLine("Пожалуйста введите положительное число. \n Попробуйте заново. ");
        return false;
    }
    return true;
}