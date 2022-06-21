// Задача 2: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0

class SumOfElementsInArray
{
    public static int SumOfElementsOnNonEvenPositions(int[] Array)
    {
        int result = 0;
        for (int i = 0; i < Array.Length; i = i + 1)
        {
            if (i % 2 != 0) result = result + Array[i];
        }
        return result;
    }
}

class ShowTask2
{
    public static void Main()
    {
        int[] TaskArray = CreateArray.CreateArrayWithRandomDigits(4);
        int TaskResult = SumOfElementsInArray.SumOfElementsOnNonEvenPositions(TaskArray);
        Console.WriteLine(TaskResult);
    }
}


