// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (rnd.Next(-10, 11));
    }
    return arr;
}

Console.Write("Введите количество элементов массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
System.Console.WriteLine(string.Join(", ", array));

int Sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if ((i - 1) % 2 != 0)
    {
        Sum+=array[i];
    }
}
System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {Sum}");