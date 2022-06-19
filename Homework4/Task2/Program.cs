// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sumInnards(int number, int result = 0)
{
    if (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
        return sumInnards(number, result);
    }
    else
    {
        return result;
    }
}

void test()
{
    Console.WriteLine(sumInnards(452));
    Console.WriteLine(sumInnards(82));
    Console.WriteLine(sumInnards(9012));
}

test();