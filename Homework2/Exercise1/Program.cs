// Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.Write("Введите трехзначное число: ");
string numStr = Console.ReadLine();
int trial = 3;
while(numStr.Length != 3)
{
    Console.Write($"Введено не трехзначное число. У вас осталось {trial} попытки. Попытайтесь еще раз: ");
    numStr = Console.ReadLine();
    trial = trial - 1;
    if (trial == 0)
    {
        Console.Write("Тестеровщик DETECTED!");
        Environment.Exit(1);
    }
}

int numInt = int.Parse(numStr);
int result = (numInt%100 - numInt%10)/10;
Console.WriteLine(result);