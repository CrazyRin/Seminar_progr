
// Задача на рекурсию: Напишите программу, которая будетт принимать на вход число и возвращать сумму его цифр.


// int SumNum(int num)
// {
//     if (num == 0) return 0;
//     // if (num == 0) break; - не подойдёт чтобы остановить функцию
//     int res = num % 10 + SumNum(num / 10);
//     return res;
// }

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine(SumNum(n));


// Задайте значение n. Напишите программу, которая вывведет все натуральные числа в промежутке от 1 до n (с помшью рекурсии)

// string Len(int stop,int start = 1)
// {
//     if (start == stop) return Convert.ToString(stop);
//     return start + " " + Len(stop,start +1);
// }


// void Len2(int num)
// {
//     if (num == 0) return;
//     Len2 (num - 1);
//     Console.Write($"{num} ");
// }



// Console.WriteLine(1+" "+ 5); пример для разделения


// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Len(n));
// Len2(n);


// Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки (используя рекусрию)


void Consonant (string s)
{
    if (s.Length == 0) return;
    string st = "aoueiy";
    if (st.Contains(s[0]) == false) Console.Write($"{s[0]}");
    Consonant(s[1..]);
}

void Consonant2 (string s,int i = 0)
{
    string st = "aoueiy";
    if (i == s.Length) return;
    if (!st.Contains(s[i])) Console.Write($"{s[i]}");
    Consonant2 (s,i+1);
}

string st = Console.ReadLine()!;
Consonant (st);
Console.WriteLine();
Consonant2 (st);



