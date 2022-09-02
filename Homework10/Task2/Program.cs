// Задача 2: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

Console.WriteLine(AkkermanFunction(3, 2));