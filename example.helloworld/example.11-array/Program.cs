void FillArray(int[] collection)

{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        // положить на позицию индекс новое случайное число от 1-10
        index++;


    }


}
void PrintArray(int[] coll)// void = возвращает метот
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(coll[position]); //значение текущего элемента

        position++;
    }


}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;// эскуственный элемент, по умолчанию если таког элемента нет ,возвращает -1:
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;//нашел первое вхождение числа
            break; //остановили програму спомощью команды
        }
        index++;
    }
    return position;
}





int[] array = new int[10]; //создал новый мосив в котором будет 10 элементов
                           //  иначе по умолчанию заполниться 0 0 0 №
FillArray(array);
array[4] = 4;//добавил 4 на 4 позицию
array[6] = 4;//добавил 4 на 6 позицию

PrintArray(array);//распечатает масив в кансоль
Console.WriteLine();

int pos = IndexOf(array, 444); //найти 4 в масиве

Console.WriteLine(pos);