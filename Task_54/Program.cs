// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            matrix[i, j] = rnd.Next(10, 100);
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

void SortRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int maxValInd = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, maxValInd] < matrix[i, k])
                {
                    maxValInd = k;
                }
            }
            int tmp = matrix[i, j];
            matrix[i, j] = matrix[i, maxValInd];
            matrix[i, maxValInd] = tmp;
        }
    }
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
    SortRows(Matrix);
    Console.WriteLine("Матрица с отсортированными строками");
    PrintMatrix(Matrix);
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