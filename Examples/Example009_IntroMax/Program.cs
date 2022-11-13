// Вывод максимума из 9 слуйчайных чисел

void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index] = new Random().Next(1,100);
        index++;
    }
}

void PrintArray (int[] arr)
{
    int count = arr.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(arr[position]);
        position++;
    }
}

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

int max = Max(Max(array[0],array[1],array[2]),Max(array[3],array[4],array[5]),Max(array[6],array[7],array[8]));

Console.WriteLine($"Максимум в массиве -> {max}");