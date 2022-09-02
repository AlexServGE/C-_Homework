// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int SumRowElements2DArray(int[,] some2DArray, int rowIndex)
{
    var sumRowElements = some2DArray[rowIndex, 0];
    for (int i = 1; i < some2DArray.GetLength(1); i = i + 1)
    {
        sumRowElements += some2DArray[rowIndex, i];

    }
    return sumRowElements;
}

int RowWithMinSumOfElements(int[,] someArray)
{
    int minSum = SumRowElements2DArray(someArray,0);
    int minSumRow = 0;
    for (int i = 1; i < someArray.GetLength(0); i = i + 1)
    {
        if(minSum > SumRowElements2DArray(someArray,i)) 
        {
            minSum = SumRowElements2DArray(someArray,i);
            minSumRow = i;
        }
    }
    return minSumRow;
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
    int[,] taskArray = Create2DArray();
    Print2DArray(taskArray);
    Console.WriteLine($"Строкой с наименьшей суммой элементов является: {RowWithMinSumOfElements(taskArray)+1}");
}

test();