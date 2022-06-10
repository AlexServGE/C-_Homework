// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int IntInput(string text)
{
    Console.Write(text);
    string numStr = Console.ReadLine();
    int numInt = int.Parse(numStr);
    return numInt;
}

bool IsEven(int number)
{
    bool[] array = { true, false };
    int IndexArray = number % 2;
    return array[IndexArray];
}

int num = IntInput("Введите число ");

if (IsEven(num))
{
    Console.WriteLine($"Число {num} является четным");
}
else
{
    Console.WriteLine($"Число {num} является нечетным");
}