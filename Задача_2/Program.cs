
//Задача 2 - Напишите программу, которая на вход принимает целое число N, а на выходе показываетт все целые числа в промежутке от -N до N

Console.Write("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int i = -N;

while (i <= N)
{
    Console.Write($"{i} ");
    i++;
}