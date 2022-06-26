// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

public class LinearMathFunctions
{
    public static void IntersectionCoordinatesForTwoLinearFunctions(float[,] Some2DArray, ref float x, ref float y)
    {
        float k1 = Some2DArray[0, 0], b1 = Some2DArray[0, 1],
                k2 = Some2DArray[1, 0], b2 = Some2DArray[1, 1];

        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
    }
}

public class EngageTheUser
{
    public static float[,] Creat2DArrayWithUserInputCoordinates()
    {
        float[,] Some2DArray = new float[2, 2];
        for (int i = 0; i < Some2DArray.GetLength(0); i = i + 1)
        {
            for (int j = 0; j < Some2DArray.GetLength(1); j = j + 1)
            {
                if (j == 0)
                {
                    Console.Write($"Введите координату k{i + 1}: ");
                    string CoordinateStr = Console.ReadLine();
                    float CoordinateInt = float.Parse(CoordinateStr);
                    Some2DArray[i, j] = CoordinateInt;
                }
                else
                {
                    Console.Write($"Введите координату b{i + 1}: ");
                    string CoordinateStr = Console.ReadLine();
                    float CoordinateInt = float.Parse(CoordinateStr);
                    Some2DArray[i, j] = CoordinateInt;
                }
            }
        }
        return Some2DArray;
    }
}
public class ShowTask2
{
    public static void Main()
    {
        float TaskX = 0;
        float TaskY = 0;
        float[,] TaskArray = EngageTheUser.Creat2DArrayWithUserInputCoordinates();
        LinearMathFunctions.IntersectionCoordinatesForTwoLinearFunctions(TaskArray, ref TaskX, ref TaskY);
        Console.WriteLine($"({TaskX},{TaskY})");
    }
}