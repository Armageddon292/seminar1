// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

Console.WriteLine("Введите число строк 1-й матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-й матрицы и число строк 2-й матрицы: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-й матрицы: ");
int w = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начало диапозона: ");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конец диапозона: ");
int maxValue = int.Parse(Console.ReadLine());
Console.WriteLine();

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] firstMartrica = new int[m, n];
GetArray(firstMartrica);
Console.WriteLine($"Первая матрица: ");
PrintArray(firstMartrica);

int[,] secomdMartrica = new int[n, w];
GetArray(secomdMartrica);
Console.WriteLine($"Вторая матрица: ");
PrintArray(secomdMartrica);

int[,] proizvedenieMatric = new int[m, w];

void ItogMatrix(int[,] firstMartrica, int[,] secomdMartrca, int[,] proizvedenieMatric)
{
    for (int i = 0; i < proizvedenieMatric.GetLength(0); i++)
    {
        for (int j = 0; j < proizvedenieMatric.GetLength(1); j++)
        {
            int proizvedenie = 0;
            for (int k = 0; k < firstMartrica.GetLength(1); k++)
            {
                proizvedenie = proizvedenie + firstMartrica[i, k] * secomdMartrica[k, j];
            }
            proizvedenieMatric[i, j] = proizvedenie;
        }
    }
}

ItogMatrix(firstMartrica, secomdMartrica, proizvedenieMatric);
Console.WriteLine($"Произведение двух матриц: ");
PrintArray(proizvedenieMatric);