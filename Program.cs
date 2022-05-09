//Вводим массив строк
string[] arrayInput = new string[] { "hello", "2", ":-)", "3", "try" };


string[] GetArrrayWithThreeSymbolsStrings(string[] array)
{
    int wordCount = 0;
    for (int i = 0; i < array.Length; i++) // цикл для нахождения количества слов, удовлетворяющих условию задачи
    {
        if (array[i].Length <= 3)
        {
            wordCount = wordCount + 1;
        }
    }

    int count = 0;
    string[] threeSymbolsArray = new string[wordCount];// создаем массив длиной равной количеству слов, удовлетворяющих условию задачи

    for (int i = 0; i < array.Length; i++) // записываем слова состоящие из 3 или менее символов в новый массив.
    {
        if (array[i].Length <= 3)
        {
            threeSymbolsArray[count] = array[i];
            count = count + 1;
        }
    }

    return threeSymbolsArray;
}

