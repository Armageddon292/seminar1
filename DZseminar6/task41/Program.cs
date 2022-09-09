//  Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите количество чисел: ");
int numbers = int.Parse(Console.ReadLine());
int[] myArray = new int[numbers];

void VhodNumbers(int numbers)
{
    for (int i = 0; i < numbers; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        myArray[i] = int.Parse(Console.ReadLine());
    }
}

int ColPolNumbers(int[] myArray)
{
    int col = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 0)
        {
            col += 1;
        }
    }
    return col;
}

VhodNumbers(numbers);

Console.WriteLine($"Чисел больше 0: {ColPolNumbers(myArray)}");