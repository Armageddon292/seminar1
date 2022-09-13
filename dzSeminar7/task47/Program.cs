// 47: Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами.

int[,] GetArray(int m, int n, int minValue, int maxValue)
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

double[,] GetDoubleArray(int m, int n)
{
    double[,] res = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i,j] = new Random().NextDouble();
        }
    }
    return res;
}

double[,] GetDoubleVseArray(int[,] array, double[,] arrayVse)
{
    double[,] res = new double[array.GetLength(0), array.GetLength(1)];
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res[i, j] = array[i, j] + arrayVse[i, j];
            Console.Write($"{res[i,j]:f2}\t ");
        }
        Console.WriteLine();
    }
    return res;
}

Console.WriteLine("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, 0, 10);
double[,] myDoubleArray = GetDoubleArray(m, n);
double[,] VseArray = GetDoubleVseArray(myArray, myDoubleArray);
