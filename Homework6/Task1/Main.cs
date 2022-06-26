// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


public class MathArray
{
    public static int CountElementsLtZero(int[] SomeArray)
    {
        int result = 0;
        for (int i = 0; i < SomeArray.Length; i = i + 1)
        {
            if (SomeArray[i] > 0) result = result + 1;
        }
        return result;
    }
}

public class CreateArray
{
    public static int[] UserFillArray(int[] SomeArray, ref int count, string WelcomeText = "wq - save and exit. \nВведите число 1: ")
    {
        Console.Write(WelcomeText);
        string ResultString = Console.ReadLine();
        if (ResultString == "wq")
        {
            return SomeArray;
        }
        else
        {
            int ResultInt = int.Parse(ResultString);
            SomeArray[count] = ResultInt;
            count = count + 1;
            WelcomeText = $"Введите число {count + 1}: ";
            return UserFillArray(SomeArray, ref count, WelcomeText);
        }
    }

    public static void PrintArray(int[] SomeArray)
    {
        Console.Write("[");
        for (int i = 0; i < SomeArray.Length; i = i + 1)
        {
            if (i == SomeArray.Length - 1)
            {
                Console.Write($"{SomeArray[i]}");
                break;
            }
            Console.Write($"{SomeArray[i]}, ");
        }
        Console.WriteLine("]");
    }
}

public class ShowTask1
{
    public static void Main()
    {
        int[] TaskArray = new int[1000];
        int Count = 0;
        TaskArray = CreateArray.UserFillArray(TaskArray, ref Count);
        // CreateArray.PrintArray(TaskArray);
        Console.WriteLine($"Пользователь ввёл {Count} чисел, из них {MathArray.CountElementsLtZero(TaskArray)} чисел больше 0.");
    }
}


