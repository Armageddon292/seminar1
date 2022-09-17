// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] myMatrica = new int[4, 4];

int i = 0;
int j = 0;
int temp = 1;

while (temp <= myMatrica.GetLength(0) * myMatrica.GetLength(1))
{
    myMatrica[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < myMatrica.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= myMatrica.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > myMatrica.GetLength(1) - 1)
        j--;
    else
        i--;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

PrintArray(myMatrica);