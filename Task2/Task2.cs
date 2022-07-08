// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

namespace Homework4
{
  class Task2
  {
    public static void Main(string[] args)
    {
  Random rand = new Random();
  int A = rand.Next(0, 11);
  int[] numbers = new int[A];
  int RandomNumbers(int A, int min, int max)
  {
  int[] randomNumbers = new int[A];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ )
    {
      randomNumbers[i] = new Random().Next(min, max);
      Console.Write(randomNumbers[i] + " ");
        if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }
  int randomNumbers =  RandomNumbers(A, 1, 10);
  Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");
    }
  }
}
