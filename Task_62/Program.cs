// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int Promt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0, 4}", $"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int sizeDim = Promt("Введите размерность квадратной матрицы");
int[,] SpiralMatrix = new int[sizeDim, sizeDim];

int count = 1;
int i = 0;//sizeDim - 1;
int j = 0;
int path = 0;
int numberOfRing = sizeDim % 2 == 0 ? sizeDim / 2 : (sizeDim / 2) + 1;

while (path < numberOfRing)
{
    while (i >= path)
    {
        SpiralMatrix[i, j] = count;
        i--;
        count++;
    }
    i++;
    j++;
    while (j < sizeDim - path)
    {
        SpiralMatrix[i, j] = count;
        j++;
        count++;
    }
    j--;
    i++;
    while (i < sizeDim - path)
    {
        SpiralMatrix[i, j] = count;
        i++;
        count++;
    }
    i--;
    j--;
    while (j >= path)
    {
        SpiralMatrix[i, j] = count;
        j--;
        count++;
    }
    i--;
    j++;
    path++;
}

PrintMatrix(SpiralMatrix);