// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[4, 5];
int rows = array.GetLength(0);
int columns = array.GetLength(1);

void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(10);
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

int[] oneDimArray = new int[rows];
int sum = 0;

for (int i = 0; i < rows; i++)
{
    sum = 0;
    for (int j = 0; j < columns; j++)
    {
        sum += array[i, j];
    }
    oneDimArray[i] = sum;
    Console.Write(oneDimArray[i] + "  ");
}

int minSum = oneDimArray[0];
int rowNum = 0;
for (int i = 0; i < rows; i++)
{
    if (oneDimArray[i] < minSum)
    {
        minSum = oneDimArray[i];
        rowNum = i;
    }
}
Console.WriteLine();
Console.WriteLine($"Строка двумеиного массива с наименьшей суммой - '{rowNum + 1}'"); //  Отсчёт не от '0' а от '1'(Для пользователя)