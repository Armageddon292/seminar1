// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

Console.Write("Введите число А: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int num2 = int.Parse(Console.ReadLine());
int proizvedenie = 1;

int VozvedenievStepen (int result)
{
    int num = 0;
    int proizvedenie = 1;
    while (num < num2)
    {
        proizvedenie = proizvedenie * num1;
        num++;
    }
    return proizvedenie;
}

Console.WriteLine($"{VozvedenievStepen(proizvedenie)}");
