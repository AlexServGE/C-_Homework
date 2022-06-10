// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool IsNotDay(int Day)
{
    if (Day < 1 || Day > 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int CheckCorrectUserInput(int Day)
{
    int trial = 3;
    while (IsNotDay(Day))
    {
        if (trial == 0)
        {
            Console.Write("Тестеровщик DETECTED!");
            Environment.Exit(1);
        }
        else
        {
            Console.Write($"Введена цифра, которой не соответствует ни один день недели. У вас осталось {trial + 1} попытки. Попытайтесь еще раз: ");
            string strDay = Console.ReadLine();
            Day = int.Parse(strDay);
            trial = trial - 1;
        }
    }
    return Day;
}

bool IsWeekEnd(int Day)
{
    if (Day == 6 || Day == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int UserInput(string Text)
{
    Console.Write(Text);
    string strDay = Console.ReadLine();
    int numDay = int.Parse(strDay);
    return numDay;
}

Console.Clear();
int numDay = UserInput("Пользователь, введите цифру, программа выведет соответствующий ей день недели. \nА также проверит, является ли этот день выходным: ");
numDay = CheckCorrectUserInput(numDay);
string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };

if (IsWeekEnd(numDay))
{
    Console.WriteLine($"Пользователь, введеной Вами цифре ({numDay}) соответствует: {week[numDay - 1]}. Это выходной!");
}
else
{
    Console.WriteLine($"Пользователь, введеной Вами цифре ({numDay}) соответствует: {week[numDay - 1]}. Это рабочий день.");
}

