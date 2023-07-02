// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Promt(string message) // запрос и считывание переменной

{
    System.Console.Write(message);
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
    Console.WriteLine();
}

void AverageRows(int[,] matrix) // Вычисление среднего значения по строкам матрицы
{
    double averageRow = 0;
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                averageRow = averageRow + matrix[i, j];
            }
            Console.WriteLine($"Среднее арифметическое строки {i + 1} равно" +
            $" {Math.Round(averageRow / matrix.GetLength(1), 2)}");
            averageRow = 0;
        }
    }
}

void AverageColumns(int[,] matrix) // Вычисление среднего значения по стролбцам матрицы
{
    double averageColumn = 0;
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                averageColumn = averageColumn + matrix[j, i];
            }
            Console.WriteLine($"Среднее арифметическое столбца {i + 1} " +
            $"равно {Math.Round(averageColumn / matrix.GetLength(0), 2)}");
            averageColumn = 0;
        }
    }
}

int rows = Promt("Введите количество строк двумерного массива ");
int columns = Promt("Введите количество столбцов двумерного массива ");
int averageFor = Promt("Для нахождения среднего арифметического по столбцам нажмите 1, по строкам 2 ");
Console.WriteLine();
if (ValidateData(rows, columns) && ValidateInput(averageFor))
{
    int[,] Matrix = new int[rows, columns];
    FillMatrix(Matrix);
    PrintMatrix(Matrix);
    switch (averageFor)
    {
        case 1:
            AverageColumns(Matrix);
            break;
        case 2:
            AverageRows(Matrix);
            break;
    }
}

bool ValidateData(int value1, int value2) // проверка введеныых значений размерности матрицы
{
    if (value1 <= 0 || value2 <= 0)
    {
        Console.WriteLine("Размерность массива не может быть отрицательной или равна 0");
        return false;
    }
    return true;
}

bool ValidateInput(int value) // проверка значения при выборе подсчета среднего по строкам/столбцам
{
    if (value == 1 || value == 2)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Вы ввели что-то не то... Попробуйте заново.");
        return false;
    }
}