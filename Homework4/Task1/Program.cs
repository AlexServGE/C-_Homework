// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


using System.Diagnostics;

// Первый вариант возведения в степень. Когда пожар или торопишься домой.

long PowRecursion(int number, int power, long result = 1)
{

    if (power > 0)
    {
        result = result * number;
        return PowRecursion(number, power - 1, result);
    }
    if (power == 0)
    {
        return result;
    }
    else
    {
        Console.WriteLine("Недопустимый параметр степени");
        return -1;
    }
}

void testPowRecursion()
{
    Console.WriteLine($"{PowRecursion(3, 5)} = 243");
    Console.WriteLine($"{PowRecursion(2, 4)} = 16");
    Console.WriteLine($"{PowRecursion(2, 1)} = 2");
    Console.WriteLine($"{PowRecursion(2, 0)} = 1");
    Console.WriteLine($"{PowRecursion(2, -1)} = Недопустимый параметр степени -1");
    Console.WriteLine($"{PowRecursion(3, 5)} = 243");
    Console.WriteLine();
}

// Второй вариант возведения в степень. Оптимизирован под возведение в большую степень

long PowOptimised(int number, int power)
{
    if (power > 0)
    {
        int maxPower = 5;                                   //если user.степень меньше 5, то уменьшаем нашу степень
        while (power / maxPower < 1)
        {
            maxPower = maxPower - 2;
            if (maxPower <= 0)
            {
                return number;
            }
        }
        long result = 1;
        long numberPowCached = Pow(number, maxPower);
        for (int i = maxPower; i <= power; i = i + maxPower)
        {
            result = result * numberPowCached;                //если user.степень от 5 до 30, то создаем промежуточный результат
            if (i == 3 * maxPower & power / i >= 2)     //если user.степень более 30, то создаем дополнительный большой промежуточный результат
            {
                int powerBig = maxPower * 3;
                long resultBig = result;
                i = i + powerBig;
                while (i <= power)
                {
                    resultBig = resultBig * result;
                    if (i + power % powerBig == power)
                    {
                        resultBig = resultBig * Pow(number, power % powerBig);
                    }
                    i = i + powerBig;
                }
                return resultBig;
            }
            if (i + power % maxPower == power)
            {
                result = result * Pow(number, power % maxPower);
            }
        }
        return result;
    }
    if (power == 0) return 1;
    else
    {
        Console.WriteLine("Недопустимый параметр степени");
        return -1;
    }
}

long Pow(int number, int power)
{
    long result = 1;
    for (int i = 1; i <= power; i = i + 1)
    {
        result = result * number;
    }
    return result;
}


void testPowOptimised()
{
    Console.WriteLine($"{PowOptimised(3, 5)} = 243");
    Console.WriteLine($"{PowOptimised(2, 4)} = 16");
    Console.WriteLine($"{PowOptimised(2, 1)} = 2");
    Console.WriteLine($"{PowOptimised(2, 0)} = 1");
    Console.WriteLine($"{PowOptimised(2, -1)} = Недопустимый параметр степени -1");
    Console.WriteLine($"{PowOptimised(3, 5)} = 243");
    Console.WriteLine();
}

TimeSpan TimeSpent(long param)
{
    Stopwatch stopWatchRec = new Stopwatch();
    stopWatchRec.Start();
    Console.WriteLine($"{param}");
    stopWatchRec.Stop();
    TimeSpan ts = stopWatchRec.Elapsed;
    Console.WriteLine(ts);
    return ts;
}

void testSpeedSmall()
{
    TimeSpan tsRec = TimeSpent(PowRecursion(3, 4));
    TimeSpan tsOpt = TimeSpent(PowOptimised(3, 4));
    TimeSpan tsIns = TimeSpent((long)Math.Pow(3, 4));

    Console.WriteLine($"Исполнение PowOptimised в {tsRec / tsOpt:F2} раза быстрее, чем PowRecursion");
    Console.WriteLine($"Исполнение PowOptimised в {tsIns / tsOpt:F2} раза быстрее, чем Math.Pow");
}

void testSpeedMedium()
{
    TimeSpan tsRec = TimeSpent(PowRecursion(3, 20));
    TimeSpan tsOpt = TimeSpent(PowOptimised(3, 20));
    TimeSpan tsIns = TimeSpent((long)Math.Pow(3, 20));

    Console.WriteLine($"Исполнение PowOptimised в {tsRec / tsOpt:F2} раза быстрее, чем PowRecursion");
    Console.WriteLine($"Исполнение PowOptimised в {tsIns / tsOpt:F2} раза быстрее, чем Math.Pow");
}

void testSpeedBig()
{
    TimeSpan tsRec = TimeSpent(PowRecursion(3, 70));
    TimeSpan tsOpt = TimeSpent(PowOptimised(3, 70));
    // TimeSpan tsIns = TimeSpent((long)Math.Pow(3, 50)); //Math.Power не может вывести числа больше ±1.7*10308

    Console.WriteLine($"Исполнение PowOptimised в {tsRec / tsOpt:F2} раза быстрее, чем PowRecursion");
    // Console.WriteLine($"Исполнение PowOptimised в {tsIns / tsOpt:F2} раза быстрее, чем Math.Pow");
}

testPowRecursion();
testPowOptimised();

Console.Write("Если хотите увидеть тест на скорость, введите слово - да: ");
string userMessage = Console.ReadLine();

if (userMessage.ToLower() == "да")
{
    testSpeedSmall();
    testSpeedMedium();
    testSpeedBig();
}
else
{
    Console.WriteLine("Будем ждать Вас снова");
}

