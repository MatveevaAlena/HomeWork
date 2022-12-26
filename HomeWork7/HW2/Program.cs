// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)

        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

int[,] result = GetMatrix(5, 6, 0, 10);
PrintMatrix(result);

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        if (i == row && j == column) 
        {
            Console.WriteLine($"Значение этого элемента: {result[i, j]}");
        }
    }
}

if (row >= result.GetLength(0) || column >= result.GetLength(1)) Console.WriteLine("Такого элемента нет");






