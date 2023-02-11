// Задача 2 - Найти сумму чисел от 1 до А

Console.WriteLine("Введите A: ");
int A = int.Parse(Console.ReadLine());

int result = 0;

for (int i = 1; i <= A; i++)
{
    result = result + i;
}
Console.WriteLine(result);
