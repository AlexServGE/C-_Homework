// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


using System.Diagnostics;

// Первый вариант возведения в степень. Когда пожар или торопишься домой.

long PowRecursion(int number, int power,long result=1)
{

    if (power>0)
    {
        result = result*number;
        return PowRecursion(number,power-1,result);
    }
    if (power ==0)
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
    if (power == 1)
    {
        return number;
    }
    if (power == 0)
    {
        return 1;
    }
    if (power >= 2)
    {
        long result = 1;
        int numberPow2Cached = Pow2(number);
        for (int i = 2; i <= power; i = i + 2)
        {
            result = result * numberPow2Cached;
            if (i + 1 == power)
            {
                result = result * number;
                break;
            }
        }
        return result;
    }
    else
    {
        Console.WriteLine("Недопустимый параметр степени");
        return -1;
    }
}

int Pow2(int number)
{
    int result = number * number;
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

void testSpeed()
{
    Stopwatch stopWatchRec = new Stopwatch();
    stopWatchRec.Start();
    Console.WriteLine($"{PowRecursion(3, 80)} = 59049");
    stopWatchRec.Stop();
    TimeSpan tsRec = stopWatchRec.Elapsed;
    Console.WriteLine(tsRec);
    Stopwatch stopWatchOpt = new Stopwatch();
    stopWatchOpt.Start();
    Console.WriteLine($"{PowOptimised(3, 80)} = 59049");
    stopWatchOpt.Stop();
    TimeSpan tsOpt = stopWatchOpt.Elapsed;
    Console.WriteLine(tsOpt);
    Console.WriteLine($"Алгоритм с рекурсие на {tsRec-tsOpt} медленнее, чем алгоритм с оптимизацией");

}

testPowRecursion();
testPowOptimised();
testSpeed();