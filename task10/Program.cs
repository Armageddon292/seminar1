// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

int randNum = new Random().Next(100,1000);
Console.WriteLine($"Случайное число: {randNum}");
int twoNum = randNum / 10 % 10;
Console.WriteLine(twoNum);