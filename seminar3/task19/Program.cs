//Напишите программу, которая принимает на вход
//пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число ");
int Num  = int.Parse(Console.ReadLine());
int Num1 = Num / 10000;
int Num2 = Num / 1000;
int Num4 = Num % 100;
int Num5 = Num % 10;
if(Num1 == Num5 && Num2 == Num4)
   {
      Console.WriteLine("Число является палиндромом");   
   }
   else
   {
       Console.WriteLine("Число не является палиндромом"); 
   }