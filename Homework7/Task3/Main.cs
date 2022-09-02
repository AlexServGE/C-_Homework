// Задача 3: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

public class CreateArray
{
    public static int[,] Create2DArrayOfRandomIntNumbers(int rows, int columns)
    {
        int[,] someArray = new int[rows, columns];
        var someRandom = new Random();
        for (int i = 0; i < rows; i = i + 1)
        {
            for (int j = 0; j < columns; j = j + 1)
            {
                someArray[i, j] = someRandom.Next(0, 10);
            }
        }
        return someArray;
    }
}

public class Math
{
    public static double[] AveragesOfElementsInColumnsOf2DArray(int[,] someArray)
    {
        double[] arrayOfAverages = new double[someArray.GetLength(1)];
        for (int j = 0; j < someArray.GetLength(1); j = j + 1)
        {
            var sumOfElementsInColumn = 0;
            for (int i = 0; i < someArray.GetLength(0); i = i + 1)
            {
                sumOfElementsInColumn += someArray[i, j];
            }
            arrayOfAverages[j] = (double)sumOfElementsInColumn / someArray.GetLength(0);
        }
        return arrayOfAverages;
    }
}
public class Print
{
    public static void Array2D(int[,] someArray)
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

    public static void Array1D(double[] someArray)
    {
        for (int i = 0; i < someArray.Length; i = i + 1)
        {
            Console.Write($"{someArray[i]:f01};\t");
        }
    }
}

class ShowTask3
{
    public static void Task3()
    {
        var TaskArray = CreateArray.Create2DArrayOfRandomIntNumbers(3, 4);
        Print.Array2D(TaskArray);
        double[] result = Math.AveragesOfElementsInColumnsOf2DArray(TaskArray);
        Print.Array1D(result);
        Console.WriteLine();
    }
    public static void Main()
    {
        Task3();
    }
}
