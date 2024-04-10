// Задача 3 - Напишите программу, которая принимает на вход  3-х значное челое число и на выходе показывает сумму первой и последней цифры этого числа

Console.Write("Введите 3-х значное число n:");
int n = Convert.ToInt32(Console.ReadLine());
int firstn = n / 100;
int third = n % 10;
int second = n / 10 % 10;
int sum = firstn + third;

if (n<100 || n>=1000)
{
    Console.Write($"Число {n} не 3-х значное.");
}
else 
{
    Console.Write($"Первоче число: {firstn}\n");
    Console.Write($"Второе число: {second}\n");
    Console.Write($"Третье число: {third}\n");
    Console.Write($"Сумма 1-го и 3-его числа: {sum}");
}
