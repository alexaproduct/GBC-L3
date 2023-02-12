// Определить количество цифр в числе

Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());

int i = 0;

while (N>0)
{
    i++;
    N=N/10;
}
Console.WriteLine("Количество цифр в числе: " + i);
