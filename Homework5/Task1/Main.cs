// Задача 1: Задайте массив заполненный случайными
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


// [345, 897, 568, 234] -> 2

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
        return SomeArray;
    }
}

public class ShowEven
{
    public static int ShowQuanitityOfEven(int[] Array)
    {
        int result = 0;
        for (int i = 0; i < Array.Length; i = i + 1)
        {
            if (Array[i] % 2 == 0) result = result + 1;
        }
        return result;
    }
}

public class ShowTask1
{
    public static void Main()
    {
        int Task1(int len = 4)
        {
            int[] Array = CreateArray.CreateArrayWithRandomDigits(len);
            int Result = ShowEven.ShowQuanitityOfEven(Array);
            return Result;
        }

        void Test()
        {
            Console.WriteLine($"-> {Task1()}");
            Console.WriteLine($"-> {Task1()}");
            Console.WriteLine($"-> {Task1()}");
            Console.WriteLine($"-> {Task1()}");
        }

        Test();
    }
}

