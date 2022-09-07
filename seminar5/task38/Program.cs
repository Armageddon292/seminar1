// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int[] GetArray(int size, int minValue,int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

double[] GetDoubleArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble();
    }
    return res;
}

double[] GetDoubleVseArray(int[] array, double[] arrayVse)
{
    double[] res = new double[array.Length];
    for (int i =0; i < array.Length; i++)
    {
        res[i] = array[i] + arrayVse[i];
    }
    return res;
}

double maxNum(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double minNum(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

Console.Write("Задайте количество элементов массива массива: ");
int size = int.Parse(Console.ReadLine());

int[] myArray = GetArray(size, 0, 10);
double[] myDoubleArray = GetDoubleArray(size);
double[] VseArray = GetDoubleVseArray(myArray, myDoubleArray);

Console.WriteLine(String.Join(", ", VseArray));

double raznica = maxNum(VseArray) - minNum(VseArray);

Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {raznica}");
