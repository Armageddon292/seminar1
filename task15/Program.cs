// 15: Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число обозначающие день недели: ");
int DayWeek  = int.Parse(Console.ReadLine());
if (0 < DayWeek && DayWeek < 8)
   {
     if (DayWeek == 6 || DayWeek == 7)
        {
            Console.WriteLine("Этот день недели является выходным");
        }
     else
        {
            Console.WriteLine("Этот день недели не является выходным");
        }
   }
else
   {
     Console.WriteLine("Это число не является числом дня недели");
   }