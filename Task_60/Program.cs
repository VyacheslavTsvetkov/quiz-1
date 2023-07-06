// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int Promt(string message)

{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillMatrix(int[,,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 10 + i;
    }
    int count = 0;
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, j, k] = array[count];
                count++;
            }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int dim1 = Promt("Введите количество строк трехмерной матрицы");
int dim2 = Promt("Введите количество столбцов трехмерной матрицы");
int dim3 = Promt("Введите количество слоев глубины трехмерной матрицы");
Console.WriteLine();

int[,,] Matrix = new int[dim1, dim2, dim3];
FillMatrix(Matrix);
PrintMatrix(Matrix);