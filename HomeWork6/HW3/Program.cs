// Задача 43 Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите десятичное число: ");
int number10 = Convert.ToInt32(Console.ReadLine());
int remainder = 0; 
int i = 0;
int[] reverseNumber2 = new int[6]; 
while (number10 >= 1)
{
    remainder = number10 % 2;
    reverseNumber2[i] = remainder;
    i++;
    number10 = number10 / 2;
    Console.Write(remainder);
}
Console.WriteLine();

int[] ReverseArray(int[] array)
{
    int size = array.Length;
    int[] result = new int[size]; 
    int last = size - 1;
    for (int i = 0; i < size; i++) 
    {
        result[i] = array[last - i]; 
    }
    return result;
}
Console.WriteLine($"Двоичное число: {String.Join("", ReverseArray(reverseNumber2))}");