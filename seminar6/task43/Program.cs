// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] koef = new double[2,2];
double[] tockaPer = new double[2];

void InKoef()
{
    for (int i = 0; i < koef.GetLength(0); i++)
    {
        Console.Write($"Введите коэфициенты уравнения: {i + 1}");
        for (int j = 0; j < koef.GetLength(0); j++)
        {
            if (j == 0)
            {
                Console.Write($"Введите коэфициент k: ");
            }
            else Console.Write($"Введите коэфициент b: ");
            koef[i,j] = int.Parse(Console.ReadLine());
        }

    }
}

double[] Peresechenie(double[,] koef)
{
    tockaPer[0] = (koef[1,1] - koef[0,1]) / (koef[0,0] - koef[1,0]);
    tockaPer[1] = tockaPer[0] * koef[0,0] + koef[0,1];
    return tockaPer;
}

InKoef();
Peresechenie(koef);
Console.Write($"Точка пересечения: ({tockaPer[0]}, {tockaPer[01]})");