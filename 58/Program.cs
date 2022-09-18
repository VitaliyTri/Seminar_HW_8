// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
int[,] AMatrix = GetMatrix(2, 2);
PrintArray(AMatrix);
Console.WriteLine();
int[,] BMatrix = GetMatrix(2, 2);
PrintArray(BMatrix);
Console.WriteLine();
int[,] CMatrix = new int[2, 2];

for (int i = 0; i < 2; ++i)
{
    for (int j = 0; j < 2; ++j)
    {
        for (int k = 0; k < 2; ++k)
        {
            CMatrix[i, k] += AMatrix[i, j] * BMatrix[j, k];
        }
    }
}
PrintArray(CMatrix);