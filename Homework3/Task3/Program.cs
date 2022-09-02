// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

double Pow3(int digit) 
{
    return digit * digit * digit;
}

void Cubes(int number)
{
    for (int i = 1; i < number; i++)
    {
        Console.Write($"{Pow3(i)}, ");
        if (i+1 == number)
        {
            Console.WriteLine($"{Pow3(i+1)}");
        }
    }
}

void test()
{
    Cubes(3);
    Cubes(5);
}

test();
