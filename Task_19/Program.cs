// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void IsPalindrom(int num)
{
    int Reverse = (num % 10) * 10000 + ((num / 10) % 10) * 1000 + ((num / 100) % 10) * 100 + ((num / 1000) % 10) * 10 + ((num / 10000) % 10);
    if (num == Reverse)
    {
        Console.WriteLine($"Да, число {num} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Нет, число {num} не является палиндромом");
    }
}


Console.Write("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());


bool ValidateNumber(int num)
{
    if (num > 10000 && num < 99999)
    {
        return true;
    }
    else
    {
        return false;
    }
}

if (ValidateNumber(number))
{
    IsPalindrom(number);
}
else
{
    Console.WriteLine($"{number} - не пятизначное число");
}