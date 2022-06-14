// Задача 1: Напишите программу, 
// которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int inputInt(string text)
{
    Console.Write(text);
    string inputStr = Console.ReadLine();
    int inputInt = int.Parse(inputStr);
    return inputInt;
}


int Count(int Number, int Length = 0)
{
    if (Number > 0)
    {
        Number = Number / 10;
        Length = Length + 1;
        return Count(Number, Length);
    }
    else
    {
        return Length;
    }
}

Console.Clear();
int NumDigit = inputInt("Введите пятизначное число и программа сообщит является ли оно палиндромом: ");
int Counter = Count(NumDigit);
Console.WriteLine($"Пользователь ввел {Counter}-значное число");

int NumDigitWIP = NumDigit;
int[] DigitsArray = new int[Counter];

for (int i = Counter - 1; i >= 0; i = i - 1)
{
    DigitsArray[i] = NumDigitWIP % 10;
    NumDigitWIP = NumDigitWIP / 10;
}

bool IsPalindrom = false;

for (int i = 0; i < Counter / 2; i++)
{
    if (DigitsArray[i] == DigitsArray[Counter - 1 - i])
    {
        IsPalindrom = true;
    }
    else
    {
        IsPalindrom = false;
        break;
    }
}

if (IsPalindrom) Console.WriteLine("Число является полиндромом");
else Console.WriteLine("Число не является полиндромом");