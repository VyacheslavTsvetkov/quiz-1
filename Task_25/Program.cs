// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Exponentiation(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result *= A;
    }
    return result;
}
Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($" Число {A} в степени {B} равняется {Exponentiation (A, B)}"); 

