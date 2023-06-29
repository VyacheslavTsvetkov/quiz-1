// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;
}

Console.Write("Введите количество элементов массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
System.Console.WriteLine(string.Join(", ", array));

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) {count++;}
}
Console.WriteLine($"Количество положительных элементов массива равно - {count}");