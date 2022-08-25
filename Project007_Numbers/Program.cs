void ShowArrayNumber(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == 1) Console.Write("#");
            else Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int[,] digit0 =
{
    {0,0,1,1,0,0},
    {0,1,0,0,1,0},
    {0,1,0,0,1,0},
    {0,1,0,0,1,0},
    {0,0,1,1,0,0}
};

int[,] digit1 =
{
    {0,0,0,1,0},
    {0,0,1,1,0},
    {0,1,0,1,0},
    {0,0,0,1,0},
    {0,0,0,1,0}
};

Console.Write("Введите число: ");
char[] num = Console.ReadLine().ToArray();


//Console.WriteLine(number)