// Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
int randomInt = new Random().Next(100,1000);
Console.WriteLine($"Внимание, случайное трёхзначное число: {randomInt}");
int result = (randomInt - randomInt%100)/10+(randomInt%10);
Console.WriteLine($"Было трёхзначным, стало двухзначным: {result}");