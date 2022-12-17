// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] array = new int[size]; 
    for (int i = 0; i < size; i++) 
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}


int GetCountElements(int[] inputArray, int leftRange, int rightRange)
{
    int count = 0;
    foreach (var item in inputArray)
    {
        if (item %2 == 0) count ++;
    }
    return count;
}
int[] resultArray = GetArray(5, 100, 1000);
Console.WriteLine($"Массив: [{String.Join(", ", resultArray)}]");

Console.WriteLine($"Количество чётных чисел в массиве: {GetCountElements(resultArray, 100, 1000)}");