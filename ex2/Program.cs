// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите три числа");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine($"Максимальное число = {a}");
    }

    else
    {
        Console.WriteLine($"Максимальное число = {c}");
        }
}

else
{
    if (b > c)
    {
        Console.WriteLine($"Максимальное число = {b}");
    }

    else
    {
        Console.WriteLine($"Максимальное число = {c}");
    }

}