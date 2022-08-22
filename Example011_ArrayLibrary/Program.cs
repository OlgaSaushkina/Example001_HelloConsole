void FillArray (int[] collection)
{   int length = collection.Length;
    int index = 0;
    while (index < length )
    {
    collection[index] = new Random().Next(1,10) ;
    index = index+1;
    }
}
void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
    Console.WriteLine(col[position]);
    position++;
    }
}

int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position= -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index= index+1;
    }
    return position;
}

int[] array = new int[10]; // создали новый массив, изначально занят нулями,  в массиве 10 элементов

FillArray(array);
array[5] =1;
array[6] = 1;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array,33);
Console.WriteLine(pos); // выводим индекс элемента
