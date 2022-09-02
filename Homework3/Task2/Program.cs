// Задача 2: Напишите программу, 
// которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Pow2(int number)
{
    double result = number * number;
    return result;
}

float Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Pow2(x1 - x2) + Pow2(y1 - y2) + Pow2(z1 - z2));
    return (float) result;
}

void test()
{
    Console.WriteLine($"{Distance3D(3,6,8,2,1,-7):F2}");
    Console.WriteLine($"{Distance3D(7,-5,0,1,-1,9):F2}");
}

test();