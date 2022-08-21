//Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число ");
int numberA  = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int numberB = int.Parse(Console.ReadLine());
if(numberA > numberB)
{
    Console.Write("число больше ");
    Console.WriteLine(numberA);
    Console.Write("число меньше ");
    Console.WriteLine(numberB);
}
else
{
    Console.Write("число больше ");
    Console.WriteLine(numberB);
    Console.Write("число меньше ");
    Console.WriteLine(numberA);
    }