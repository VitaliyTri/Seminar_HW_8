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

int[,] array = new int[5, 5];
int rows = array.GetLength(0);
int columns = array.GetLength(1);

void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(10,100);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);

Console.WriteLine();
int tempMin = 0;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int k = j + 1; k < columns; k++) 
        {
            if (array[i, k] > array[i, j])
            {
                tempMin = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = tempMin;
            }
        }

    }
}
PrintArray(array);