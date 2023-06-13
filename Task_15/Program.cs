// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool IsWeekend(int day)
{
    if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
    {
        return false;
    }
    else if (day == 6 || day == 7)
    {
        return true;
    }
    else
    {
       return false; 
    }
}

Console.Write("Введите день недели ");
int days = Convert.ToInt32(Console.ReadLine());

if (IsWeekend(days))
{
    Console.Write("выходной!!");
}
else
{
    Console.Write("будни");
}
