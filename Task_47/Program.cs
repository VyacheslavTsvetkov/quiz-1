// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Promt(string message)

{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillMatrix(double[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * 100, 2);
        }
    }
}

void PrintMatrix(double[,] matrix)
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

int rows = Promt("Введите количество строк двумерного массива ");
int columns = Promt("Введите количество столбцов двумерного массива ");
Console.WriteLine();
if (ValidateData(rows, columns))
{
    double[,] Matrix = new double[rows, columns];
    FillMatrix(Matrix);
    PrintMatrix(Matrix);
}


bool ValidateData(int value1, int value2)
{
    if (value1 <= 0 || value2 <= 0)
    {
        Console.WriteLine("Размерность массива не может быть отрицательной или равна 0");
        return false;
    }
    return true;
}