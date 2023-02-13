// Мутод заполнения массива случайными числами от 0 до 10
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

// void - ознвчает, что по завершению метода, значение не возвращается

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;

    // int position = 0;
    int position = -1; // присвоим отрицательное значение на случай, если значения find нет в заданном массиве
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

// Определим новый массив из 10ти элементов 
// (по умолчанию он будет заполнен нулями)
int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();  // пропустим строку после вывода массива на экран

int pos = IndexOf(array, 45);
Console.WriteLine(pos);