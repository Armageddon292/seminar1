// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N: ");
int numN = int.Parse(Console.ReadLine());
int count = 1;
while (count <= numN)
{
   Console.Write($"{count*count*count}, ");
   count++;  
}
Console.WriteLine();