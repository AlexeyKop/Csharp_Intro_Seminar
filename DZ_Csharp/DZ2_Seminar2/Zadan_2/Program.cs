// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
Console.Clear();
Console.WriteLine("Введите координату Х: ");
int X = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine()!);
if (X ==  0 || Y == 0)
    Console.WriteLine("Координаты Х и Y не должны быть = 0");
else 
    if (X > 0 && Y > 0) Console.WriteLine($"Координаты Х:'{X}' и Y:'{Y}' => 1");
    if (X < 0 && Y > 0) Console.WriteLine($"Координаты Х:'{X}' и Y:'{Y}' => 2");
    if (X < 0 && Y < 0) Console.WriteLine($"Координаты Х:'{X}' и Y:'{Y}' => 3");
    if (X > 0 && Y < 0) Console.WriteLine($"Координаты Х:'{X}' и Y:'{Y}' => 4");


