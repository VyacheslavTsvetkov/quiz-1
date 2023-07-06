// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

int Promt(string message)

{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void FindMinRow(int[,] matrix)
{
    int count = 0;
    int rowSum = 0;
    int minRowIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            count = 0;
            count += matrix[i, j];
        }
        if (rowSum == 0 || rowSum > count)
        {
            rowSum = count;
            minRowIndex = i;
        }

    }
    Console.WriteLine($"номер строки с наименьшей суммой элементов - {minRowIndex + 1}");
}

int rows = Promt("Введите количество строк матрицы");
int columns = Promt("Введите количество столбцов матрицы");
Console.WriteLine();
if (ValidateData(rows, columns))
{
    int[,] Matrix = new int[rows, columns];
    FillMatrix(Matrix);
    Console.WriteLine("Исходная матрица");
    PrintMatrix(Matrix);
    Console.WriteLine();
    FindMinRow(Matrix);
}

bool ValidateData(int value1, int value2)
{
    if (value1 <= 0 || value2 <= 0)
    {
        Console.WriteLine("Размерность массива не может быть отрицательной или равна 0. Попробуйте заново.");
        return false;
    }
    return true;
}