using System;

Console.Write("Enter array size: ");

int.TryParse(Console.ReadLine(), out var arraySize);

var arrayOfIntegers = new int[arraySize];

FillingArrayWithRandomNumbers(arrayOfIntegers, 1, 27);

void FillingArrayWithRandomNumbers(int[] arrayOfIntegers, int min, int max)
{
    for (var i = 0; i < arrayOfIntegers.Length; i++)
    {
        arrayOfIntegers[i] = new Random().Next(min, max);
    }
}