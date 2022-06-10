// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9


int IntInput(string text)
{
    Console.Write(text);
    string numStr = Console.ReadLine();
    int numInt = int.Parse(numStr);
    return numInt;
}

int num1 = IntInput("Введите первое число");
int num2 = IntInput("Введите второе число");


if (num1 > num2)
{
    Console.WriteLine($"max = {num1}, min = {num2}");
}
else
{
    if (num1 < num2)
    {
        Console.WriteLine($"max = {num2}, min = {num1}");
    }
    else
    {
        Console.WriteLine($"Числа равны");
    }
}