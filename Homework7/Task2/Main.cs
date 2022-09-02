// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

int UserInput(string welcomeText)
{
    Console.Write(welcomeText);
    string inputString = Console.ReadLine();
    int inputInt = int.Parse(inputString);
    return inputInt;
}

int[,] Create2DArrayOfRandomIntNumbers(int rows, int columns)
{
    int[,] someArray = new int[rows, columns];
    var someRandom = new Random();
    for (int i = 0; i < rows; i = i + 1)
    {
        for (int j = 0; j < columns; j = j + 1)
        {
            someArray[i, j] = someRandom.Next(-10, 11);
        }
    }
    return someArray;
}

void Print2DArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < someArray.GetLength(1); j = j + 1)
        {
            Console.Write($"{someArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FindElementIn2DArrayByCoordinates(int[,] someArray, int row, int column)
{
    if (row - 1> someArray.GetLength(0) || column - 1 > someArray.GetLength(1))
    {
        Console.WriteLine($"{row}{column} -> такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine(someArray[row - 1, column - 1]);
    }
}

var TaskArray = Create2DArrayOfRandomIntNumbers(3, 4);
Print2DArray(TaskArray);
var row = UserInput("Введите координату строки:$ ");
var column = UserInput("Введите координату столбца:$ ");
FindElementIn2DArrayByCoordinates(TaskArray, row, column);