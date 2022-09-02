// Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void third_num(string num)
{
    if (num.Length < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine(num[2]);
    }
}

void Test()
{
    
    Console.WriteLine("Режим автотестировщика ЗАПУЩЕН.");
    Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    third_num("645");
    third_num("78");
    third_num("32679");
    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
    Console.WriteLine("Режим автотестировщика ЗАВЕРШЕН. Ошибок не обнаружено.");
    Console.WriteLine("Режим пользователь ИНИЦИИРОВАН.");
}

Console.Clear();
Test();
Console.Write("Пользователь, введите любую цифру: ");
string UserInputStr = Console.ReadLine();
third_num(UserInputStr);

