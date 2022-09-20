// Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.

void SumotMdoN(int m, int n)
{
    Console.Write(Summa(m -1, n));
}

int Summa(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = Summa(m, n) + m;
        return result;
    }
}

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

SumotMdoN(m, n);
