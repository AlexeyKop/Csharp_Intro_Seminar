// Список (List) - может содержать люб тип данных (int, double, str, bool)
// занимает много памяти, долго обрабатыв.
// Массивы (Array) - один тип данных

/*
int[] array = {34, -10, 23, 9, 8};
// for (int i = 0; i < array.Length; i++)  // вывод массива через цикл for
// {
//     Console.Write($"{array[i]} ");
// }
Console.WriteLine(string.Join(", ", array)); // вывод через Join - соединять, работает в str
*/

/*
Console.Clear();
Console.Write("Введите кол-во эл-тов:");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
Console.WriteLine($"Начал массив: [{string.Join(", ", array)}]");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,11); // [1, 10]
}
Console.WriteLine($"Конеч массив: [{string.Join(", ", array)}]");
*/
/*
Console.Clear();
Console.Write("Введите кол-во эл-тов:");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n]; // 0.0
// Random().NextDoble() - (0,1);
// from 20 to 30 - Random().NextDoble() * (end - start) + start;
Console.WriteLine($"Начал массив: [{string.Join(", ", array)}]");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(new Random().NextDouble() * (30-20)+20, 2);
}
Console.WriteLine($"Конеч массив: [{string.Join(", ", array)}]");
*/

/*
// Функции и процедуры
void test(ref int m) // Процедура (ничего не возвращает). ref позволяет передавать ссылку 
                    //на значение в оперативной памяти (в дан случае -> 7)
{
    m = m + 10;
}

Console.Clear();
int n = 7;
test(ref n);
Console.Write(n);
*/

/*
// Функции
int maxNumber(int a, int b){
    if (a > b)
        return a; // функц return возвращ значен и заверш работу функции 
    return b;  // else можно не прописывать
}

Console.Clear();
Console.Write("Введите 1-е число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Наибол значен: {maxNumber(n,m)}");
*/

/*
void inputArray(int[] arr)  // при работе с масссивами нет никакой необходимости передавать 
                            //знач по ССЫЛКЕ (ref). Они передаются автоматически.
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(-10,11); // [-10, 10]   
}

Console.Clear();
Console.Write("Введ кол элем массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

Console.WriteLine($"Начал массив: [{string.Join(", ", array)}]");
inputArray(array);
Console.WriteLine($"Конеч массив: [{string.Join(", ", array)}]");
*/

/*
// Задач 4 из предыдущ ДЗ: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
while (n > 0){
    int x = n % 10;
    Console.Write($"{x}, ");
    n /= 10;
}
*/

/*
// Задание 1. Совместная работа

//  Задайте одномерный массив, заполненный случайными числами. 
// Определите количество простых чисел в этом массиве.
//  Примеры
//  [1 3 4 19 3] => 2 [4 3 4 1 9 5 21 13]  => 3

void inputArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(1,101); // [1, 100]   
}

bool isPrime(int n){    // у любого простого числа ТОЛЬКО 2 делителя: 1 и само число
                        // у составного числа делитель будет находится в промежутке от 2 до n/2 
    for (int i =2; i <= n/2; i++){
        if (n % i == 0)
            return false;
    }
    return true;
}

Console.Clear();
Console.Write("Введ кол элем массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начал массив: [{string.Join(", ", array)}]");
Console.Write("простые числа: ");
for (int i = 0; i < array.Length; i++)
{
    if (isPrime(array[i]) == true)
        Console.Write($"{array[i]},");
}
*/

/*
// Задание 2. Работа в сессионных залах
//  Семинар 4. Функции
//  Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
//  Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
//  Пример
//  [1 5 11 21 81 4 0 91 2 3]
//  => 2

void inputArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(-1000,1001); 
}

int isCheck(int[] array){
    int count = 0;
    foreach (int element in array){
        if (element % 10 == 1 && element % 7 == 0){
            Console.WriteLine(element);
            count++;
        }
    }
    return count;
}

Console.Clear();
Console.Write("Введ кол элем массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начал массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {isCheck(array)}");

*/

// Задание 3. Совместная работа
//  Семинар 4. Функции
//  Заполните массив на  N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. 
//  Сформируйте целое число, которое будет состоять из цифр из массива. 
// Старший разряд числа находится на 0-м индексе, младший – на последнем. 
//  Пример
//  [1 3 2 4 2 3] => 132423; [2 3 1] => 231

void inputArray(int[] arr)  
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(0,9); // [0, 8]   
}

int formingNumber(int[] array)
{
    int result = 0;
    int i = array.Length - 1;
    foreach (int el in array){
        result += el * Convert.ToInt32(Math.Pow(10, i));
        i--;
    }
    return result;
}
Console.Clear();
Console.Write("Введ кол элем массива: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 0 || n > 8){
    Console.Write("Вы ошиблись! Введите числ от 0 до 8");
    n = int.Parse(Console.ReadLine()!);
}

int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начал массив: [{string.Join(", ", array)}]");
//Console.WriteLine($"Результат: {string.Join("", array)}"); // можно резултат вывести в виде строки;)
Console.WriteLine($"Начал массив: {formingNumber(array)}");
