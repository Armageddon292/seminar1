// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size, int minValue,int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int ColChetChisel(int[] array)
{
    int[] res = new int[array.Length];
    int col = 0;
    for (int i =0; i < array.Length; i++)
    {
        int chet = array [i] % 2;
        if (chet == 0)
        col++;
    }
    return col;    
}

int[] myArray = GetArray(10, 100, 999);
Console.WriteLine(String.Join(" ", myArray));

int result = ColChetChisel(myArray);
Console.WriteLine($"Количество чётных чисел: {result}");