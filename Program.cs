// Домашняя работа к семинару 1 по C#

//Задание 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите число a");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число b");
// int b = int.Parse(Console.ReadLine());
// if (a > b)
// {
//     System.Console.WriteLine("Большее число " + a);
// }
// else
// {
//     System.Console.WriteLine("Большее число " + b);
// }

//Задание 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c");
int c = int.Parse(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine("Максимальное число " + a);
}
else if (b > a && b > c)
{
    Console.WriteLine("Максимальное число " + b);
}
else if (c > a && c > b)
{
    Console.WriteLine("Максимальное число " + c);
}