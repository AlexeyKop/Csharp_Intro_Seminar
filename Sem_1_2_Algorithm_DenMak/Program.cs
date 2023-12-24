// Семинар 1.(16.11.23)
/*
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!); // быстрее
Console.Write("Введите 2-ое число: ");
float m = int.Parse(Console.ReadLine()!); // double, либо float (одно из чисел должно быть с дробной частью)
// // int m = Convert.ToInt32(Console.ReadLine()); - второй способ преобразования в целое число
// // "456" -> 456 -> n = 456
Console.WriteLine($"{n} + {m} = {n + m}");
Console.WriteLine($"{n} - {m} = {n - m}");
Console.WriteLine($"{n} * {m} = {n * m}");
Console.WriteLine($"{n} : {m} = {n / m} (ост. {n % m})");
*/

/*
// Задача 1
Console.Clear();
Console.Write("введите 1-е число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("введите 2-е число: ");
int m = int.Parse(Console.ReadLine()!);
if (m * m == n)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");

*/

// На входе число n, на выходе все целые числа в промежутке от -n до n.
//Задача 2(1)
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// for (int i = -n; i <= n; i++)
//     Console.Write($"{i} ");

// Задача 2(2)
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int i = -n;
// while (i <= n)
// {
//     Console.Write($"{i} ");
//     i++;
// }

// Задача 3
/*
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine()!);
int n3 = n % 10;
int n1 = n / 100;
Console.Write(n1 + n3);
*/

/*
Семинар 2 (20.11.23)
Алгебра Логики (Булевская Алгебра) - 0(False) или 1(True)
Алфавит десятичный СС: 0 1 2 3 4 5 6 7 8 9 
*/
/*
Console.Clear();
Console.Write("Введите число:");
int n = int.Parse(Console.ReadLine()!);
//Console.WriteLine(n > 3 && n < 15 );
Console.WriteLine(n > 3 && (n < 15 || n % 2 == 0));
// bool (Boolean) - True or False
// && (and) - конъюнкция (логич умножение)
// || (or) - дизъюнкция (логич сложение)
*/

/*
// Задание 1
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 100 || n > 999)
{
    Console.Write("Вы ошиблись!\n Введите трёхзначное число: ");
    n = int.Parse(Console.ReadLine()!);
}


// a = 256 => 26
// a = 891 => 81

// int n1 = n / 100;
// int n3 = n % 10;
// Console.WriteLine (n1 * 10 + n3 * 1);

// Задание 2

int n2 = (n / 10) % 10;
int n3 = n % 10, result = 1;
for (int i = 1; i <= n3; i++)
{
    result = result * n2;
}
Console.WriteLine($"{n2}^{n3} = {result}");
*/

/*
// Задание 3
using System.Diagnostics;

Console.Clear();
Console.Write ("Введите 1-ое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.Write ("Введите 2-ое число: ");
int secondNumber = int.Parse(Console.ReadLine()!);
if (firstNumber % secondNumber == 0)
    Console.WriteLine("да");
else
    Console.WriteLine($"нет, остаток от деления: {firstNumber % secondNumber}");
*/

// Задание 4
using System.Globalization;

Console.Clear();
Console.Write ("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
number = Math.Abs(number); // модуль числа |-5| = 5
if (number < 100)
    Console.WriteLine("Третьей цифры нет");
else{
    Console.WriteLine(number % 1000 / 100);
}