//  Задание_1 Задайте значение m и n. Напишите программуб которая выведет все натуральные числа в промежутке от m до n. Использовать рекурсиюб не использовать циклы.


// string Len(int stop,int start)
// {
//     if (start == stop) return Convert.ToString(stop);
//     return start + "," + Len(stop,start +1);
// }

// Console.Write ("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (m<n) Console.WriteLine(Len(n,m));
// else Console.WriteLine(Len(m,n));



//  Задание_2 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны 2 неотрицательных числа m и n.

// Console.Write("Введите значение m1: ");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение n1: ");
// int n1 = Convert.ToInt32(Console.ReadLine());

// int akkerman(int m1, int n1)
// {
//     if (m1 == 0) return n1 + 1;
//     else if (n1 == 0) return akkerman(m1 - 1, 1);
//     else return akkerman(m1 - 1, akkerman(m1, n1 - 1));
// }

// Console.Write($"Функция Аккермана равно {akkerman(m1, n1)}");



//  Задание_3 Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


void Mass (int[] s)
{
    if (s.Length == 0) return;
    Mass(s[1..]);
    Console.Write($"{s[0]} ");
}


int[] array = [1, 5, 3, 7, 5, 6, 13];

Mass (array);