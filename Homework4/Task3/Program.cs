// Напишите программу, которая задаёт массив из 
// 8 элементов 
// случайными числами и 
// выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
// 6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1

int[] RandomArray()
{
    int[] Array = new int[8];
    for (int i = 0; i < Array.Length; i = i + 1)
    {
        Array[i] = new Random().Next(0, 100);
    }
    return Array;
}

void PrintArray(int[] Array)
{
    foreach (int el in Array)
    {
        if (el == Array[Array.Length-1])
        {
            Console.Write($"{el}");
            break;
        }
        Console.Write($"{el}, ");
    }
}

PrintArray(RandomArray());