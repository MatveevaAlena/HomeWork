// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows = 2;
int columns = 2;

Console.WriteLine("Первая матрица:");
int[,] matrix1 = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix1[i, j] = new Random().Next(11);
        Console.Write(matrix1[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Вторая матрица:");
int[,] matrix2 = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix2[i, j] = new Random().Next(11);
        Console.Write(matrix2[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Результирующая матрица:");
int[,] result = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        result[i, j] = matrix1[i, j] * matrix2[i, j];
        Console.Write(result[i, j] + "\t");
    }
    Console.WriteLine();
}