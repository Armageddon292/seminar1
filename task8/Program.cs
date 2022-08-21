// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите положительное число больше 1 ");
int num = int.Parse(Console.ReadLine());
int num2 = 2;
while (num2 <= num)
{
    Console.Write($" {num2}");
    num2 = num2 + 2;
}