// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MultiplyTwoMatrix(int[,] matrixA, int[,] matrixB, int[,] resultMatrix)
{
    int sum = 0;
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {

        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            resultMatrix[i, j] = sum;
        }

    }
}

int rows1 = Promt("Введите количество строк первой матрицы");
int columns1 = Promt("Введите количество столбцов первой матрицы");
int rows2 = Promt("Введите количество строк второй матрицы");
int columns2 = Promt("Введите количество столбцов второй матрицы");
Console.WriteLine();
if (ValidateData(rows1, columns1, rows2, columns2))
{
    if (ValidateMatrix(columns1, rows2))
    {
        int[,] MatrixA = new int[rows1, columns1];
        int[,] MatrixB = new int[rows2, columns2];
        int[,] MultipliedMatrix = new int[rows1, columns2];
        FillMatrix(MatrixA);
        FillMatrix(MatrixB);
        Console.WriteLine("Исходная матрица #1");
        PrintMatrix(MatrixA);
        Console.WriteLine();
        Console.WriteLine("Исходная матрица #2");
        PrintMatrix(MatrixB);
        Console.WriteLine();
        MultiplyTwoMatrix(MatrixA, MatrixB, MultipliedMatrix);
        Console.WriteLine("Результат перемножения матриц 1 и 2");
        PrintMatrix(MultipliedMatrix);
    }
}

bool ValidateData(int row1, int col1, int row2, int col2)
{
    if (row1 <= 0 || col1 <= 0 || row2 <= 0 || col2 <= 0)
    {
        Console.WriteLine("При введенных значениях размерностей матриц их" +
        "\n произведение невозможно. Попробуйте заново.");
        return false;
    }
    return true;
}

bool ValidateMatrix(int col1, int row2)
{
    if (col1 != row2)
    {
        Console.WriteLine("При введенных значениях размерностей матриц их" +
           "\n произведение невозможно. Попробуйте заново.");
        return false;
    }
    return true;
}