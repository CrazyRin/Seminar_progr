

using System;
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;


//1 Задайте двумерный массив (тип char[,]). Создать строку из символов этого массива


void CharsOfString2(char[,] arr)
{
    string st = "";
    foreach (var i in arr)
    {
        st += i; //st = st +i
    }
    Console.WriteLine(st);

}

char[,] chars = new char[,] { { 'a', '1' }, { 'b', 'c' }, { 'd', 'z' } };
// Console.WriteLine(chars[1,1]);
CharsOfString2(chars);


//2 Задайте строкуб содержащую латинсике буквы в обоих регистрах. Сформируте строку, в которой все заглавные буквы заменены на строчные Меттод.ToLower()


string lower(string str)
{
    string str_2 = str.ToLower();
    return str_2;
}

string str_1 = "Hello WORLD";
Console.WriteLine(lower(str_1));


//3 Задайте произвольную строку. Выясните, является ли она "палиндромом".


void palingdrom(string str)
{
    string un_str = "";
    for (int i = 1; i <= str.Length; i++)
    {
        un_str = un_str + str[str.Length - i];
    }
    if (un_str == str)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }

}

Console.Write("Задайте произвольную строку: ");
string n_string = Console.ReadLine()!;
palingdrom(n_string);



//4 Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. в полученной строке слова должны быть также разделены пробелами.



void split (string arr)
{
    string[] arr_1 = arr.Split(" ");
    string arr_2 = ""; 
    for (int i = 1; i <= arr_1.Length; i++)
    {
        arr_2  = arr_2 + " " + arr_1[arr_1.Length-i];
    }
    Console.WriteLine(arr_2);
}

string st = "Орден мужества для павстанцев";
split (st);



