// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


int IntInput(string text)
{
    Console.Write(text);
    string numStr = Console.ReadLine();
    int numInt = int.Parse(numStr);
    return numInt;
}

int num1 = IntInput("Введите первое число: ");
int num2 = IntInput("Введите второе число: ");
int num3 = IntInput("Введите третье число: ");

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine($"Максимальное число: {max}");