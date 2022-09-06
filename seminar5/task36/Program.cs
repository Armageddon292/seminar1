// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int size, int minValue,int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SumChiselsNechInd(int[] myArray)
{   
    int sum = 0;
    for (int i = 1; i < myArray.Length; i+=2)
    {
        sum += myArray[i];
    }
    return sum;
}

int[] myArray = GetArray(10, 1, 10);
Console.WriteLine(String.Join(" ", myArray));

int result = SumChiselsNechInd(myArray);
Console.WriteLine($"Сумма чисел с нечётными индексами: {result}");