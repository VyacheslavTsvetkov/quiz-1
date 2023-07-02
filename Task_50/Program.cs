// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение этого
//  элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void FindPosition(int rowPos, int columnPos, int[,] matrix)
{
    Console.WriteLine($"В строке {rowPos} и столбце {columnPos} находится элемент {matrix[rowPos - 1, columnPos - 1]}");
}

Random rnd = new Random();
int rows = rnd.Next(1, 10);
int columns = rnd.Next(1, 10);
int rowPos = Promt("Введите номер строки элемента ");
int columnPos = Promt("Введите номер столбца элемента ");
Console.WriteLine();


int[,] Matrix = new int[rows, columns];
FillMatrix(Matrix);
PrintMatrix(Matrix);
System.Console.WriteLine();
if (rowPos <= Matrix.GetLength(0) && columnPos <= Matrix.GetLength(1))
{
    FindPosition(rowPos, columnPos, Matrix);
}
else
{
    Console.WriteLine("такого элемента нет, т.к. вы ввели значения" +
    " строк/столбцов, которые выходят за диапазон матрицы");
}


