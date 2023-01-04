// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = 4;
int columns = 5;
int minSum = int.MaxValue;
int indexMinSumRows = 0;


int[,] matrix = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + "\t");
        sum += matrix[i, j];
    }
    Console.WriteLine($"Сумма элементов строки {i} = {sum}");
    Console.WriteLine();
    if (sum < minSum)
    {
        minSum = sum;
        indexMinSumRows = i;
    }
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexMinSumRows} строка");
