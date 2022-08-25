void SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = array[i];
        int index = i;

        for (int j = 1 + i; j < array.Length; j++)
        {
            if(min > array[j]) 
            {
                min = array[j];
                index = j;
            }
        }

        int temp = array[index];
        array[index] = array[i];
        array[i] = temp;
    }
}

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }

    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

int[] arr = CreateArray(10, 1, 10);
PrintArray(arr);
SortArray(arr);
PrintArray(arr);