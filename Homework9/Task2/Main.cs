// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


int ShowSumOfNumbersFromAToB(int A, int B)
{
    if (A < B) return ShowSumOfNumbersFromAToB(A+1,B)+A;
    else return A;
}

Console.WriteLine(ShowSumOfNumbersFromAToB(1, 15));
Console.WriteLine(ShowSumOfNumbersFromAToB(4, 8));