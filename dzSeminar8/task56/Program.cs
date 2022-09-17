// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начало диапозона: ");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конец диапозона: ");
int maxValue = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[m, n];

void GetArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

GetArray(array);
PrintArray(array);

int rowvithMinSumma = 0;
int summaRow = RowSummaNumbers(array, 0);
for (int i = 1; i < m; i++)
{
    int tempSummaRow = RowSummaNumbers(array, i);
    if (summaRow > tempSummaRow)
    {
        summaRow = tempSummaRow;
        rowvithMinSumma = i;
    }
}

int RowSummaNumbers(int[,] array, int i)
{
    int summaRow = array[i, 0];
    for (int j = 1; j < n; j++)
    {
        summaRow = summaRow + array[i, j];
    }
    return summaRow;
}

Console.WriteLine($"строкa с наименьшей суммой элементов: {rowvithMinSumma + 1} сумма чисел равна: {summaRow}");
