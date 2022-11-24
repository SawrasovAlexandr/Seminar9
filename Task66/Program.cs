// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumXToY(int x, int y)
{
    if (x > y) return 0;
    return x += SumXToY(++x, y);
}

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
if (m > n) 
{
    int temp = n;
    n = m;
    m = temp;
}
Console.WriteLine($"Cуммa натуральных элементов в промежутке от M до N равна: {SumXToY(m, n)}");