// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int getPow(int a, int b)
{
    int res = a;
    for (int i = 1; i < b; i++)
    {
        res *= a;
    }
    return res;
}
Console.WriteLine(getPow(a , b));
