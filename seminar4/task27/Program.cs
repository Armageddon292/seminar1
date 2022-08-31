// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SummaChisel(int num)
{
    int sum = 0;
    int col = 0;
    int numsum =0;
    while (num > 0)
    {
        numsum = num % 10;
        sum = sum + numsum;
        num = num / 10;
        col++;
    }
    return sum;
}

Console.Write("Введите число: ");
int summa = int.Parse(Console.ReadLine());
Console.WriteLine($"{SummaChisel(summa)}");
