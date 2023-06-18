
void printArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void SortArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int MaxPos = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[MaxPos])
            {
                MaxPos = j;
            }

        }
        int temp = arr[i];
        arr[i] = arr[MaxPos];
        arr[MaxPos] = temp;
    }
}

int[] CreateArray(int[] array, int length)
{
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

Console.Write("введите количество элементов массива ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int [N];

CreateArray(array, N);
Console.WriteLine("исходный  массив");
printArray(array);
Console.WriteLine();
Console.WriteLine("отсортированный массив");
SortArray(array);
printArray(array);