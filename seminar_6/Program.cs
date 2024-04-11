
// Позволяет писать на кириллице
// using System;
// using System.Text;
// Console.InputEncoding = Encoding.Unicode;
// Console.OutputEncoding = Encoding.Unicode;


// создание массива char

// string CharsOfString(char[] arr)
// {
//     string st = "";
//     for (int i = 0 ; i < arr.Length; i++)
//     {
//         st += arr[i];
//     }
//     return st;

// }    

// string CharsOfString2(char[] arr)
// void CharsOfString2(char[,] arr)
// {
//     string st = "";
//     foreach (var i in arr)
    // {
    //     st += i; //st = st +i
    // }

    // return st;
    // Console.WriteLine(st);

// }    


// string st2 = "12345";
// for (int i = 0; i < st2.Length; i++)
// {
//     Console.WriteLine(st2[i]);
// }

// char[] chars = new char[] {'a','1','b','c','d','z'};
// char[,] chars = new char[,] {{'a','1'},{'b','c'},{'d','z'}};
// string st = CharsOfString(chars); 
// Console.WriteLine(CharsOfString(chars));
// Console.WriteLine(CharsOfString2(chars));
// CharsOfString2(chars);

// char[] chars2 = new char[] {'a','3','g','c','d','z'};
// // string st = CharsOfString(chars); 
// Console.WriteLine(CharsOfString(chars2));
// Console.WriteLine(CharsOfString2(chars2));



//Создание массива char из символов string


// void PrintMass(char[] collection)
// {
//     foreach (var item in collection)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }


// string n = Console.ReadLine()!;
// char[] mass=new char[n.Length];
// for (int i = 0; i <n.Length;i++)
// {
//     mass[i] =n[i];
// }

// PrintMass(mass);




// Задание 3 - Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди введенных букв гласных (aouei)

// int FindVowels(string str)
// {
//     string vowels = "aoueiаеуыоюиояэAOUEIЕУЗАОЭЯИЮ";
//     int count = 0;
//     for (int i = 0; i < str.Length;i++)
//     {
//         for (int j = 0; j < vowels.Length;j++)
//         {
//             if (str[i] == vowels[j])
//             {
//                 count++;
//                 break;
//             }
//         }
//     }
//     return count;
// }


// Console.Write("Введите строку: ");
// string n = Console.ReadLine()!;
// int res = FindVowels(n);
// Console.WriteLine(res);





//DZ

// string st = "KLLKLikdldksgj".ToLower();
// Console.WriteLine(st);


string st = "sfsf sfsf, sfsfsf";
string[] arr = st.Split(" ");
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[2]+" "+arr[1]+" "+ arr[0]);




