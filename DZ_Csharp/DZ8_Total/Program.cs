// Метод для генерации случайного массива строк
string[] GenerateRandomArray(int minLength, int maxLength)
{
    Random random = new Random();
    int length = random.Next(minLength, maxLength);

    string[] array = new string[length];

    for (int i = 0; i < length; i++)
    {
        int stringLength = random.Next(1, 7);
        char[] chars = new char[stringLength];

        // Генерация случайной строки
        for (int j = 0; j < stringLength; j++)
        {
            chars[j] = (char)random.Next('А', 'я');
        }

        array[i] = new string(chars);
    }

    return array;
}

// Метод для фильтрации массива строк
string[] FilterArray(string[] originalArray)
{
    int count = 0;

    // Подсчет количества строк, удовлетворяющих условию
    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length <= 3)  count++;            
    }

    // Создание нового массива с отфильтрованными строками
    string[] newArray = new string[count];
    int index = 0;

    // Заполнение нового массива отфильтрованными строками
    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length <= 3)
        {
            newArray[index] = originalArray[i];
            index++;
        }
    }
    return newArray;
}