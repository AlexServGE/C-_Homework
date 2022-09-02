// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] Create2DArray(int rows = 3, int columns = 4)
{
    int[,] someArray = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < rows; i = i + 1)
    {
        for (int j = 0; j < columns; j = j + 1)
        {
            someArray[i, j] = rnd.Next(-10, 11);
        }
    }
    return someArray;
}

int[] Create1DArray(int[,] some2DArray, int rowIndex)
{
    int[] cach1DArray = new int[some2DArray.GetLength(1)];
    for (int i = 0; i < some2DArray.GetLength(1); i = i + 1)
    {
        cach1DArray[i] = some2DArray[rowIndex, i];
    }
    return cach1DArray;
}

int[] Sort1DArray(int[] some1DArray)
{
    int cachElement;
    for (int k = 0; k < some1DArray.Length; k = k + 1)
    {
        for (int l = k + 1; l < some1DArray.Length; l = l + 1)
        {
            if (some1DArray[k] < some1DArray[l])
            {
                cachElement = some1DArray[l];
                some1DArray[l] = some1DArray[k];
                some1DArray[k] = cachElement;
            }
        }
    }
    return some1DArray;
}

void Print2DArray(int[,] someArray)
{
    Console.WriteLine();
    for (int i = 0; i < someArray.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < someArray.GetLength(1); j = j + 1)
        {
            Console.Write($"{someArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Sort2DArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i = i + 1)
    {
        int[] sortedCachArray = Sort1DArray(Create1DArray(someArray, i));
        for (int j = 0; j < someArray.GetLength(1); j = j + 1)
        {
            someArray[i, j] = sortedCachArray[j];
        }
    }
    return someArray;
}

void test()
{
    int[,] taskArray = Create2DArray();
    Print2DArray(taskArray);
    int[,] resultTaskArray = Sort2DArray(taskArray);
    Print2DArray(resultTaskArray);
}

test();