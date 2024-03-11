// Задача 1: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

static void Nature (int m, int n)
{
    if (m > 0 && m <= n)
    {
        Console.WriteLine(m);
    }
    else if (m > 0 && m >= n)
    {
        Console.WriteLine(m);
    }
    if (m < n)
    {
        Nature(m + 1, n);
    }
    else if (m > n)
    {
        Nature(m - 1, n);
    }
}
Nature(4, 9);