// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}
double[] resultArray = GetArray(4, 1, 100);
Console.WriteLine($"Массив: [{String.Join(", ", resultArray)}]");

double min = resultArray[0];
double max = resultArray[0];
foreach (var item in resultArray)
{
    if (item < min) min = item;
    if (item > max) max = item;
}
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементом массива = {max - min}");