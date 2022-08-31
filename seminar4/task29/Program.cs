// Напишите программу, которая задаёт массив из N элементов, 
// заполненных случайнми числами из [a, b) и выводит их на экран.

Console.Write("Введите количество элементов массива: ");
int Razmer = int.Parse(Console.ReadLine());

int [] InitArray()
{
    int Length = Razmer;
    int [] arr = new int[Length];
    int i = 0;
    while (i < arr.Length)
    {
        arr[i] = new Random().Next(1,6);
        i++;
    }
    return arr;
}

Console.WriteLine(String.Join(", ", InitArray()));