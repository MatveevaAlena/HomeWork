// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int rows = 2;
int columns = 2;
int depth = 2;
int temp = 0;


int[,,] matrix3D = new int[rows, columns, depth];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int k = 0; k < depth; k++)
        {
            matrix3D[i, j, k] = new Random().Next(10, 100);
            if (matrix3D[i, j, k] != temp)
            {
                Console.Write($"{matrix3D[i, j, k]} ({i},{j},{k})" + "\t");
            }
            temp = matrix3D[i, j, k];
        }
        Console.WriteLine();
    }
}
