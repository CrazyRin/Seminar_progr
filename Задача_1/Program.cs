

// Как задокументировать строку `cntrl+/`

// Задача 1 - проверка на равенство числа 1 с квадратом числа 2
Console.Write("Введите перове число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2*number2)
{
    Console.WriteLine($"Квадрат числа {number2} равен {number1}");
}
else Console.WriteLine("Квадрат числа {0} не равен {1}", number1, number2);

string number3 = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(number3);
