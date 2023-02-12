// Задать массив из 8 элементов и 
// вывести их на экран

int[] arr = new int[8];

for (int i = 0; i <= 7; i++)
{
    arr[i] = new Random().Next(1, 100);
    Console.WriteLine(arr[i]);
}