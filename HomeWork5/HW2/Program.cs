// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] array = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
int[] resultArray = GetArray(6, -100 , 100);

Console.WriteLine(String.Join(", ", resultArray));

int i = 1;
int sum = 0;
while ( i < resultArray.Length)
{
    sum = sum + resultArray[i];
    i +=2;
}
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях в массиве: " + sum);