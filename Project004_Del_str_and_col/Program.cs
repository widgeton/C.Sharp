int col = 5, str = 5;
int[,] arr = new int[str, col];

Console.WriteLine("Исходный массив: ");
for(int i = 0; i < str; i++)
{
    for(int j = 0; j < col; j++)
    {
        arr[i, j] = new Random().Next(100);
        Console.Write(arr[i, j]+"\t");
    }
    Console.WriteLine();
}

Console.Write("Введите номер удаляемой строки: ");
int delStr = Int32.Parse(Console.ReadLine()) - 1;

Console.Write("Введите номер удаляемой колонки: ");
int delCol = Int32.Parse(Console.ReadLine()) - 1;

int[,] arr2 = new int[str-1, col-1];

Console.WriteLine("Измененный массив: ");
for(int i = 0; i < str - 1; i++)
{
    for(int j = 0; j < col - 1; j++)
    {
        if(i < delStr && j < delCol) arr2[i, j] = arr[i, j];
        else if(i >= delStr && j >= delCol) arr2[i, j] = arr[i+1, j+1];
        else if(i < delStr && j >= delCol) arr2[i, j] = arr[i, j+1];
        else if(i >= delStr && j < delCol) arr2[i, j] = arr[i+1, j];
        Console.Write(arr2[i, j]+"\t");
    }
    Console.WriteLine();
}
Console.WriteLine();