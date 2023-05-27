// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] arr = new int[10];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(100, 1000);
}

int count = 0;
for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] % 2 == 0)
    {
        count+=arr[i];
    }
}

System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
System.Console.WriteLine($"Count: {count}");