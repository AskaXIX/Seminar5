// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] arr = new int[10];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(-99, 99);
}

int max = 0;
int min = 0;
int res = 0;

for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] > max) max = arr[i];
    else if(arr[i] <= min) min = arr[i];
}

res = max - min;

System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
System.Console.WriteLine($"Difference between max & min: {max} & {min} = {res}");