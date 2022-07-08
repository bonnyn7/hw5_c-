// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

namespace Homework5
{
  class Task1
  {
    public static void Main(string[] args)
    {
    Random rand = new Random();
    int A = rand.Next(0, 11);
    int[] numbers = new int[A];

    void FillArray(int[] array, int min, int max)
    {
        for (int i = 0; i<array.Length; i++ )
        {
        array[i] = new Random().Next(min, max);
        }
    }

    void WriteArray(int[] array)
    {
        for (int i = 0; i<array.Length; i++ )
        {
        Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

        int QuantityPositive(int[] array){
        int numPositive = 0;
        for (int i = 0; i<array.Length; i++ )
        {
            if (array[i] % 2 == 1)
                {
                     numPositive++;
                }
        }
        return numPositive;
    }
    FillArray(numbers, 100, 1000);
    WriteArray(numbers);
    Console.WriteLine();

    int numPositive = QuantityPositive(numbers);
    Console.WriteLine($"Количество чётных чисел в массиве: {numPositive}");
    }
  }
}