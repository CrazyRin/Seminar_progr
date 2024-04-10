using System.Dynamic;
// Задача_1 - Напишите прогу, которая на входе принимает 2 числа и выдаёт, какое число больше а какое меньше

// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже
//         // Console.Write("Введите перове число 1: ");
//         // int firstNumber = Convert.ToInt32(Console.ReadLine());
//         // Console.Write("Введите второе число 2: ");
//         // int secondNumber = Convert.ToInt32(Console.ReadLine());

//         if (firstNumber > secondNumber)
//         {
//             Console.Write("первое число больше");
//         }
//         else if (firstNumber < secondNumber)
//         {
//             Console.Write("второе число больше");
//         } 
//         else
//         {
//             Console.Write("числа равны");
//         }
//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 5;
//             secondNumber = 5;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }

// Задача_2 - Напишите прогу, которая принимает 3 числа и выдаёт максимальное из них


// using System;

// public class Answer {
    
//   static int FindMax(int a, int b, int c)
//     {
//       // Введите свое решение ниже

//     int[] n = new int[] {a,b,c};
//     int max = n[0];

//     for  (int i = 1; i < 3; i++)
//     {
//         if (max < n[i])
//         {
//             max=n[i];
//         }
//     }
//     return (max);


//     }

//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = 15;
//            b = 8;
//            c = 15;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }


// Задача_3 - Напишите прогу, которая на вход принимает число и выдаёт, является ли число четным

// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//       // Введите свое решение ниже
//     if (number % 2 == 0)
//     {
//         Console.Write("четное");
//     }
//     else 
//     {
//         Console.Write("нечетное");
//     }

//     }
  

//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 135;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }



// Задача_4 - Напишите прогу, которая на вход принимает число n, а на выход показывает все четные числа от 1 до n




using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
    int i = 1;

    while (i <= number)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i} ");
        }
        i++;
    }

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}