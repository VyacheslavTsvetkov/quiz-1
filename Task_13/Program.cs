// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

string FindDigit(string list)
{
    list = list.Substring(2);
    list = list.Substring(0, 1);
    return list;
}

System.Console.WriteLine("введите число");
string number = Console.ReadLine();

if (number.Length < 3)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    System.Console.WriteLine($"третья цифра {FindDigit(number)}");
}