// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую: ");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);

int GetCountElements(int[] inputArray)
{
    int count = 0;
    foreach (var item in inputArray)
    {
        if (item > 0) count++;
    }
    return count;
}
Console.WriteLine($"Количество положительных элементов: {GetCountElements(numbers)}");