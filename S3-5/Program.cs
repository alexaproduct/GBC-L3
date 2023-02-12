// Задать массив из 12 элементов, 
// заполненных числами из [0,9].
// Найти сумму положительных/отрицательных 
// элементов массива

int[] arr = new int[12];

for (int i = 0; i <= 11; i++)
{
    arr[i] = new Random().Next(-10, 10);
    Console.WriteLine(arr[i]);
}

int sum = arr.Sum();
Console.WriteLine();
Console.WriteLine("Сумма всех чисел: " + sum);

int sum1 = 0;

for (int i = 0; i <= 11; i++)
{
    if (arr[i] >= 0)
    sum1 = sum1 + arr[i];
}
Console.WriteLine();
Console.WriteLine("Сумма положительных чисел: " + sum1);

int sum2 = 0;

for (int i = 0; i <= 11; i++)
{
    if (arr[i] < 0)
    sum2 = sum2 + arr[i];
}
Console.WriteLine();
Console.WriteLine("Сумма отрицательных чисел: " + sum2);