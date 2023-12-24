using System;
//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

Console.Clear();
Console.WriteLine("Введите двузначное число из диапозона от 10 до 99");
int number = int.Parse(Console.ReadLine()!);
while (number < 10 || number > 99)
{
    Console.WriteLine("Ошибка, введите двузначное число: ");
    number = int.Parse(Console.ReadLine()!);
}
if (number / 10 > number % 10) 
    Console.WriteLine ($"наибольшая цифра числа {number} => {number / 10}");
else 
    Console.WriteLine ($"наибольшая цифра числа {number} => {number % 10}");

