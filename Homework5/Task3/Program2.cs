public class CreateArray
{
    public static int[] CreateArrayWithRandomDigits(int len)
    {
        int[] SomeArray = new int[len];
        for (int i = 0; i < len; i = i + 1)
        {
            SomeArray[i] = new Random().Next(100, 1000);
            Console.Write($"{SomeArray[i]} | ");
        }
        Console.WriteLine();
        return SomeArray;
    }

    public static double[] CreateArrayWithFloatDigits(int len)
    {
        double[] SomeArray = new double[len];
        for (int i = 0; i < len; i = i + 1)
        {
            SomeArray[i] = Math.Round(100*new Random().NextDouble(),2);
            Console.Write($"{SomeArray[i]} | ");
        }
        Console.WriteLine();
        return SomeArray;
    }
}

public class ShowEven
{
    public static int ShowQuanitityOfEven(int[] Array)
    {
        int Result = 0;
        for (int i = 0; i < Array.Length; i = i + 1)
        {
            if (Array[i] % 2 == 0) Result = Result + 1;
        }
        return Result;
    }
}

