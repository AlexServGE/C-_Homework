// Задача 3: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

int[,] Create2DArray(int rows = 3, int columns = 4)
{
    int[,] someArray = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < rows; i = i + 1)
    {
        for (int j = 0; j < columns; j = j + 1)
        {
            someArray[i, j] = rnd.Next(0, 11);
        }
    }
    return someArray;
}

int[,] MulTwo2DArrays(int[,] someArray1, int[,] someArray2)
{
    int[,] result2DArray = new int[someArray1.GetLength(0), someArray1.GetLength(1)];
    for (int i = 0; i < someArray1.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < someArray1.GetLength(1); j = j + 1)
        {
            result2DArray[i, j] = someArray1[i, j] * someArray2[i, j];
        }
    }
    return result2DArray;
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


void test()
{
    int[,] taskArray1 = Create2DArray();
    int[,] taskArray2 = Create2DArray();
    Print2DArray(taskArray1);
    Print2DArray(taskArray2);
    int[,] resultTaskArray = MulTwo2DArrays(taskArray1,taskArray2);
    Print2DArray(resultTaskArray);
}

test();