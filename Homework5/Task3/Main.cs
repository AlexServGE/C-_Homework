// Задача 3: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.

// [3, 7, 22, 2, 78] -> 76

public class CreateArray
{
    public static double[] CreateArrayWithFloatDigits(int len)
    {
        double[] SomeArray = new double[len];
        for (int i = 0; i < len; i = i + 1)
        {
            SomeArray[i] = Math.Round(100 * new Random().NextDouble(), 2);
            Console.Write($"{SomeArray[i]} | ");
        }
        Console.WriteLine();
        return SomeArray;
    }
}
public class MathArrayElements
{
    public static double DifferenceMaxVsMinElements(double[] Array)
    {
        double Result = 0;
        double Max = Array[0];
        double Min = Array[0];
        for (int i = 1; i < Array.Length; i = i + 1)
        {
            if (Array[i] > Max) Max = Array[i];
            if (Array[i] < Min) Min = Array[i];
        }
        Console.Write($"{Max} - {Min} = ");
        Result = Math.Round(Max - Min, 2);
        return Result;
    }
}

public class ShowTask3
{
    public static void Main()
    {
        double Task3(int len = 4)
        {
            double[] TaskArray = CreateArray.CreateArrayWithFloatDigits(len);
            double TaskResult = MathArrayElements.DifferenceMaxVsMinElements(TaskArray);
            return TaskResult;
        }

        void Test()
        {
            Console.WriteLine($"{Task3()}");
            Console.WriteLine($"{Task3()}");
            Console.WriteLine($"{Task3()}");
            Console.WriteLine($"{Task3()}");
        }

        Test();
    }
}