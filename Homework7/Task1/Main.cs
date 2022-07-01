// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9


int UserInput(string welcomeText)
{
    Console.Write(welcomeText);
    string inputString = Console.ReadLine();
    int inputInt = int.Parse(inputString);
    return inputInt;
}

double[,] Create2DArrayOfRandomFloatNumbers(int rows, int columns)
{
    double[,] someArray = new double[rows, columns];
    var someRandom = new Random();
    for (int i = 0; i < rows; i = i + 1)
    {
        for (int j = 0; j < columns; j = j + 1)
        {
            someArray[i, j] = someRandom.NextDouble() * 10 * someRandom.Next(-1, 2);
        }
    }
    return someArray;
}

void Print2DArray(double[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < someArray.GetLength(1); j = j + 1)
        {
            Console.Write($"{someArray[i, j]:f01}\t");
        }
        Console.WriteLine();
    }
}

var rows = UserInput("Введите количество строк для создания массива:$ ");
var columns = UserInput("Введите количество столбцов для создания массива:$ ");
var TaskArray = Create2DArrayOfRandomFloatNumbers(rows, columns);
Print2DArray(TaskArray);