// Задача 4: Заполните спирально квадратный массив по возрастанию, с
// заданным размером:

// 1   2   3   4
// 12  13  14  5
// 11  16  15  6
// 10  9   8   7

void Print2DArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($"{someArray[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateEmpty2DSquareArray(int rows)
{
    int[,] some2DArray = new int[rows, rows];
    return some2DArray;
}

int[,] FillSpiral2DArray(int[,] some2DArray, int cach = 0, int border = 0)
{
    if (border == (int)Math.Ceiling((decimal)some2DArray.GetLength(0) / 2))
    {
        return some2DArray;
    }
    int length = some2DArray.GetLength(0);
    int triggerLength = 0;
    int triggerWidth = 0;
    if (triggerLength == 0 && triggerWidth == 0)
    {
        int increment = 0;
        for (int j = border; j < length - border; j++)
        {
            increment++;
            some2DArray[border, j] = increment + cach;
            if (j == length - 1 - border) cach = some2DArray[border, j];
        }
        triggerLength = 1;
        triggerWidth = 0;
    }
    if (triggerLength == 1 && triggerWidth == 0)
    {
        int increment = 0;
        for (int i = border + 1; i < length - border; i++)
        {
            increment++;
            some2DArray[i, length - 1 - border] = increment + cach;
            if (i == length - 1 - border) cach = some2DArray[i, length - 1 - border];
        }
        triggerLength = 0;
        triggerWidth = 1;
    }
    if (triggerLength == 0 && triggerWidth == 1)
    {
        int increment = 0;
        for (int j = length - 2 - border; j >= border; j--)
        {
            increment++;
            some2DArray[length - 1 - border, j] = cach + increment;
            if (j == border) cach = some2DArray[length - 1 - border, j];
        }
        triggerLength = 1;
        triggerWidth = 1;
    }
    if (triggerLength == 1 && triggerWidth == 1)
    {
        int increment = 0;
        for (int i = length - 2 - border; i > border; i--)
        {
            increment++;
            some2DArray[i, border] = cach + increment;
            if (i == border + 1) cach = some2DArray[i, border];
        }
    }
    return FillSpiral2DArray(some2DArray, cach, border + 1);
}

int[,] some2DArray = CreateEmpty2DSquareArray(9);
some2DArray = FillSpiral2DArray(some2DArray);
Print2DArray(some2DArray);

