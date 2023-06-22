// Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int CountDigit(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

System.Console.WriteLine("Введите число, которое укладывается в диапазон от 0 до 2 147 483 647 ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    System.Console.WriteLine("вы ввели отрицательное число, попробуйте снова");
}
else
{
    System.Console.WriteLine($"Сумма всех чискл числа {number} равна {CountDigit(number)}");
}
