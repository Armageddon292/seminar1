// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int m, int n,int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i=0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
     return result;   
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, 0, 10);
PrintArray(myArray);

for (int j = 0; j < myArray.GetLength(1); j++)
{
    double sredneeArif = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        sredneeArif = (sredneeArif + myArray[i,j]);
    }
    sredneeArif = sredneeArif / m;
    Console.Write(sredneeArif + "; ");
}
