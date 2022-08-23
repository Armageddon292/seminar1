// Напишите программу, которая выводит третью цифру (справа налево)
// заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число ");
int Num  = int.Parse(Console.ReadLine());
int Num2 = Num / 100;
int Num3 = Num2 % 10;
 if (Num2 == 0)
  {
    Console.Write("Третьей цифры в числе нет ");
  }
else 
  {
     Console.Write($"Третья цифра числа = {Num3} ");
  }