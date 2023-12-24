
// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.

Console.Clear();
Console.Write("Введите любое натуральное число: ");
string num = (Console.ReadLine()!);
int n = num.Length;
int number = int.Parse(num);

int j = 1;
for (int k = 0; k < n-1;  k++)  {j = j * 10;}
int i = 0;
while (i < n)
{
    int res = number / j % 10;
    j = j / 10;
    i++;
    Console.Write($"{res},");
}


