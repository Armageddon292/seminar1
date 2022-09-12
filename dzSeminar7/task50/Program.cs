// Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, 
// и возвращает индексы этого элемента или же указание, что такого элемента нет.

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

Console.WriteLine("Введите число которое хотите найти в массиве: ");
int Number = int.Parse(Console.ReadLine());

void EstNumber (int num, int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (num == array[i, j])
            {
                Console.WriteLine($"Идекс числа: {i}, {j}");
                return;
            }
        }
    }    
    Console.WriteLine("Такого числа в массиве нет");
}

EstNumber(Number, myArray);