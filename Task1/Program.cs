// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] arr = new int[10];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(100, 1000);
}

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
System.Console.WriteLine($"Count: {count}");