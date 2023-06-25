// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] FillArray(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 100, 2);
    }
    return arr;
}

Console.Write("Введите количество элементов массива ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(size);
System.Console.WriteLine(string.Join(", ", array));

double difference = Math.Round(array.Max() - array.Min(), 2);
Console.WriteLine($"Разница между максимальным и минимальным значениями массива равно {difference}");