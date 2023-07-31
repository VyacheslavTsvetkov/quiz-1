/*
Задача: Написать программу, которая из имеющегося массива строк формирует
 новый массив из строк, длина которых меньше, либо равна 3 символам. 
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
 выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
 лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


int Promt(string message)
{
    System.Console.WriteLine(message);
    string result = string.Parse(Console.ReadLine()!);
    int number = 0;
    bool isNumber = int.TryParse(result, out number);
    if (isNumber) return number;
    else Console.WriteLine($"{result} - не является числом. Попробуйте заново.");
}

bool ValidateNumber(int value)
{
    if (value <= 0)
    {
        Console.WriteLine("Вы ввели число меньше или равное нулю. \n Попробуйте заново. ");
        return false;
    }
    return true;
}

int N = Promt("Введите число элементов массива");
Console.WriteLine();
