// Строки
// На вход - число. посчитатайте сумму цифр данного числа.
using System.ComponentModel;
/*
Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine()!; // строка
int result = 0;
for (int i = 0; i < number.Length; i++){
    Console.WriteLine(number[i]);  // выводится СИМВОЛ в терминал
    Console.WriteLine(Convert.ToInt32(number[i])); // выводится КОДИРОВКА (UTF-8 with BOM) 
                                                    //данного символа
    Console.WriteLine(Convert.ToInt32(number[i].ToString())); // функц .ToString 
                                                //переводит тип данных chr в string
    result += Convert.ToInt32(number[i].ToString());  // ToInt32 переводит str в integer                                                                                           
}
Console.WriteLine($"Summ цифр числа = {result}");
*/
// ==========================
/*
// Зад 2 из ДЗ.
// Напишите прогу, котор определ кол-во чётн чискел в массиве из 10 цел чисел.

void InputArray(int[] array){  // заполн массив случ числами
    for (int i = 0; i < 10; i++){  
        array[i] = new Random().Next(-10, 11);
    }
}

int evenNumbers(int[] array){  //дан функция считает кол-во чётн элементов
    int count = 0;
    foreach (int el in array){
        if (el % 2 == 0)
            count++;
    }
    return count;
}

Console.Clear();
int [] array = new int[10];
InputArray(array);
Console.WriteLine($"Begining array: [{string.Join(",", array)}]");
Console.WriteLine($"Result: {evenNumbers(array)}");
*/
//===========================
/*
//Зад 4* из ДЗ: Дано натуральное число в диапазоне от 1 до 100 000. 
//Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива, 
//младший – на последнем. Размер массива должен быть равен количеству цифр.

Console.Clear();
int number = new Random().Next(1, 100001);
int n = number;
int count = 0;
while (n > 0){
    n /= 10;
    count++;
}
Console.WriteLine(number);
Console.WriteLine(count);
int[] array = new int[count];
while (count > 0){
    array [count - 1] = number % 10;
    number /= 10;
    count --;
}
Console.WriteLine($"Result: [{string.Join(",", array)}]");
*/
// ======================
/*
// Зад.1 Урок. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

void InputMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,31);
        }
    }
}

void PrintMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }

}

void replaceMatrix(int [,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i,j] = matrix[i,j] * matrix[i,j];
        }
    }
}
 
Console.Clear();
Console.Write("Введ размеры двумерн массива: ");
int [] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// Console.ReadLine()! - "4 5" ввожу 2 числа (раз-р массива): 4 строки и 5 столбцов
// (STRING.Split(" ")). - ["4", "5"] - разделяет элементы строки по пробелам и создает массив из строк
// Select(x => int.Parse(x)) - 4 5 - переводит в integer элементы строк, но это НЕ массив
// ToArray() - [4, 5] - переводит обратно в массив
int [,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Begining array: ");
PrintMatrix(matrix);
replaceMatrix(matrix);
Console.WriteLine("Result array: ");
PrintMatrix(matrix);

*/
//==========================
/*
// // Задание 2. Работа в сессионных залах
//  Семинар 5. Двумерные массивы
//  Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
//  диагонали (с индексами (0,0); (1;1) и т.д.


void InputMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,31);
        }
    }
}

void PrintMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }

}

int summaElement(int [,] matrix){
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
                result += matrix[i, i];           
        }
    }
    return result;
}

Console.Clear();
Console.Write("Введ размеры двумерн массива: ");
int [] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

int [,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Begining array: ");
PrintMatrix(matrix);
Console.WriteLine($"Sum of element of main diagonal:{summaElement(matrix)}");
*/
//============================

// Задание 3. Совместная работа
// Семинар 5. Двумерные массивы
// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, 
// состоящий из средних арифметических значений по строкам двумерного массива.
void InputMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,11);
        }
    }
}

void PrintMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }

}

double [] AVG(int [,] matrix){
    double [] avg_array = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double summa = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summa += matrix[i, j];       
        }
        avg_array[i] = summa / matrix.GetLength(1);
    }
    return avg_array;
}

Console.Clear();
Console.Write("Введ размеры двумерн массива: ");
int [] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

int [,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Begining array: ");
PrintMatrix(matrix);
Console.WriteLine($"Arithmet mean of strings:[{string.Join(", ", AVG(matrix))}]");

//=============================







