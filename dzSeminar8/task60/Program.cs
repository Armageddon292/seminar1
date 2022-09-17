// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

void GetArray(int[,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (int w = 0; w < array.GetLength(2); w++)
            {
                array[m, n, w] = temp[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray.GetLength(2); k++)
            {
                Console.Write($"{myArray[i, j, k]} =({i} {j} {k}); ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите 1-й размер массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-й размер массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3-й размер массива: ");
int w = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,,] myArray = new int[m, n, w];
GetArray(myArray);
PrintArray(myArray);