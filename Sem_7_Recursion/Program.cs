// // Рекурсия
// Напишите программу, которая принимает от пользователя 2 числа. 
// Необходимо сложить введенные числа, без прямого сложения.
/*
int summa(int a, int b){
    if (b == 0)
        return a;
    return summa (a + 1, b - 1);
}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Результат: {a} + {b} = {summa(a, b)}");
*/
// =====================

// Задача 1. Seminar.
// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Обычный метод решения (без рекурсии):
// Console.Clear();
// Console.WriteLine("введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int result = 0;
// while (n != 0){ // n < 10 || n % 10 = n || n / 10 == 0 - одно и тоже условие
//     result += n % 10;
//     n/= 10;
// }
// Console.WriteLine(result);
/*
int summaCifr(int n){
    if (n < 10)
        return n;
    return summaCifr(n / 10) + n % 10;
}
Console.Clear();
Console.WriteLine("введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(summaCifr(n));
*/
// =====================
// Задача 2. Seminar.
// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
/*
string printNumber (int n){
    if (n == 0) // n == 1 можно и так было задать условие
        return " "; // return "1 "
    return printNumber (n - 1) + $"{n} ";
}

Console.Clear();
Console.WriteLine("введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(printNumber(n));
*/

// Задача 3 Seminar
// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки

bool checkVowels(char s){
    char[] c = {'e', 'u', 'i', 'y', 'a', 'o'};
    foreach (char el in c){
        if (el == s)
            return false;
    }
    return true;
}

string printChars(string s){
    if (s.Length == 0)
        return "";

    string s_new = String.Empty;
    for (int i = 0; i < s.Length - 1; i++)
        s_new += s[i];

    if (checkVowels(s[s.Length - 1])){
        return printChars(s_new) + $"{s[s.Length - 1]} ";
    }
    return printChars(s_new);
}

Console.Clear();
Console.WriteLine("Введите строку: ");
string initial = Console.ReadLine()!;
Console.WriteLine(printChars(initial));