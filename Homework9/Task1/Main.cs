// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


void ShowEvenNumbersFromAToB(int A, int B)
{
    if (A == B || A + 1 == B)
    {
        Console.Write($"{B}");
        return;
    }
    if (B % 2 == 0)
    {
        ShowEvenNumbersFromAToB(A, B - 2);
    }
    else
    {
        B = B - 1;
        ShowEvenNumbersFromAToB(A, B - 2);
    }
    Console.Write($" {B}");
}


ShowEvenNumbersFromAToB(1, 5);
Console.WriteLine();
ShowEvenNumbersFromAToB(4, 8);