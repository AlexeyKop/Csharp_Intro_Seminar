// Задание 1. Совместная работа
//  Семинар 3. Массивы
//  Задайте  массив.  Напишите  программу,  которая  определяет,
// присутствует  ли  заданное  число  в  массиве.  
//Программа должна выдать ответ: Да/Нет.
//  Примеры
//  [1 3 4 19 3], 8 => Нет 
//  [-4 3 4 1], 3 => Да? 



int [] FillArray(int size) // Метод который заполняет массив
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-5, 6);
    }
    return array;
}


void PrintArray(int[] inArray)  // метод вывода на печать
                                // подсвечивает жёлтым - метод объявлен, но не используется
{
    for(int i = 0; i<inArray.Length; i++)
    {
        Console.Write(inArray[i] + " ");
    }
    Console.WriteLine(); // пернос на следующую строку
}

// 1-й способ:
// void FindNumberInArray(int num, int[] ar) // метод ищет заданное число в массиве
// {
//     foreach(int element in ar) // пока element (это значение) будет находится в массиве, 
//                                 //будет работать цикл. Перебор всех элементов массива.
//     {
//         if(element == num)
//         {
//             Console.WriteLine ("Yes");
//         }
//         else
//         {
//             Console.WriteLine ("No");
//         }
//     }
// }

// 2-й способ с помощью флага (flag)
void FindNumberInArray(int num, int[] ar) // метод ищет заданное число в массиве
{
    bool flag = false;
    foreach(int element in ar) // пока element (это значение) будет находится в массиве, 
                                //будет работать цикл. Перебор всех элементов массива.
    {
        if(element == num)
        {
            flag = true;
        }
        
    }
    if (flag)  // True, проверяется истинность
    {
        Console.Write("Yes");
    }
    else
    {
        Console.Write("No");
    }
}


//здесь начинается работа программы
int lengthArray1 = 8;
int[] arr1 = FillArray(lengthArray1);  // создаем массив arr1 c помощью метода FllArray
//Console.Write(arr1) // при запуске выдает ссылку System.Int32[], т.е. говорит, 
                        //что массив создан, но на печать не выводит
PrintArray(arr1); // вызываем метод для печати массива


int lengthArray2 = 12;
int[] arr2 = FillArray(lengthArray2);
PrintArray(arr2);

int number = Convert.ToInt32(Console.ReadLine());
FindNumberInArray(number, arr1);
FindNumberInArray(number, arr2);


//Console.Write(arr);



// void PrintArray(int[] inArray)
// {
//     for (int i = 0; if < inArray.Length; if++)
// }