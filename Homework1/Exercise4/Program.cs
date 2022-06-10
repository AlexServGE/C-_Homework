// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


int IntInput(string text)
{
    Console.Write(text);
    string numStr = Console.ReadLine();
    int numInt = int.Parse(numStr);
    return numInt;
}

int N = IntInput("Введите число: ");

if (N > 1)
{
    int i = 2;
    while (i <= N)
    {
        if (i == N || i + 1 == N) // так как в задании примеры заканчиваются без запятой в конце. также ловим и убираем запятую на нечетных N
        {
            Console.Write($"{i}");
            break;
        }
        Console.Write($"{i}, ");
        i = i + 2;
    }
}
else
{
    int i = 0;
    while (i >= N)
    {
        if (i == N || i - 1 == N)
        {
            Console.Write($"{i}");
            break;
        }
        Console.Write($"{i}, ");
        i = i - 2;

    }
}