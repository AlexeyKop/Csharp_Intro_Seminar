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
