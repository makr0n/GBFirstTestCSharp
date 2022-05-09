//Вводим массив строк
string[] arrayInput = new string[] { "hello", "2", ":-)", "3", "try" };


string[] GetArrayWithThreeSymbolsStrings(string[] array)
{
    int wordCount = 0;
    for (int i = 0; i < array.Length; i++) // цикл для нахождения количества слов, удовлетворяющих условию задачи
    {
        if (array[i].Length <= 3)
        {
            wordCount++;
        }
    }

    int count = 0;
    string[] threeSymbolsArray = new string[wordCount];// создаем массив длиной равной количеству слов, удовлетворяющих условию задачи

    for (int i = 0; i < array.Length; i++) // записываем слова состоящие из 3 или менее символов в новый массив.
    {
        if (array[i].Length <= 3)
        {
            threeSymbolsArray[count] = array[i];
            count++;
        }
    }

    return threeSymbolsArray;
}

void PrintArray(string[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        if (i < count - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine("]");
}


PrintArray(arrayInput);
string[] newArray = GetArrayWithThreeSymbolsStrings(arrayInput);
PrintArray(newArray);
Console.WriteLine();


