void ShowMatrix(int[,] array)
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

int[,] ComposeMatrices(int[,] matrix1, int[,] matrix2)
{
    int row = matrix1.GetLength(0) > matrix2.GetLength(0) ? matrix1.GetLength(0) : matrix2.GetLength(0);
    int col = matrix1.GetLength(1) + matrix2.GetLength(1);
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix[i, j] = matrix1[i, j];
        }
    }

    for (int i = 0, k = 0; i < row; i++, k++)
    {
        for (int j = matrix1.GetLength(1), l = 0; j < col; j++, l++)
        {
            matrix[i, j] = matrix2[k, l];
        }
    }
    
    return matrix;
}

int[,] nullMatrix = {{0}, {0}};

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

int[,] digit2 =
{
    {0,0,1,1,0,0},
    {0,1,0,0,1,0},
    {0,0,0,1,0,0},
    {0,0,1,0,0,0},
    {0,1,1,1,1,0}
};

int[,] digit3 =
{
    {0,0,1,1,0,0},
    {0,1,0,0,1,0},
    {0,0,0,1,0,0},
    {0,1,0,0,1,0},
    {0,0,1,1,0,0}
};

int[,] digit4 =
{
    {0,0,0,0,1,0},
    {0,0,0,1,1,0},
    {0,0,1,0,1,0},
    {0,1,1,1,1,0},
    {0,0,0,0,1,0}
};

int[,] digit5 =
{
    {0,1,1,1,1,0},
    {0,1,0,0,0,0},
    {0,1,1,1,0,0},
    {0,0,0,0,1,0},
    {0,1,1,1,0,0}
};

int[,] digit6 =
{
    {0,0,1,1,0,0},
    {0,1,0,0,0,0},
    {0,1,1,1,0,0},
    {0,1,0,0,1,0},
    {0,0,1,1,0,0}
};

int[,] digit7 =
{
    {0,1,1,1,1,0},
    {0,0,0,1,0,0},
    {0,0,1,0,0,0},
    {0,1,0,0,0,0},
    {0,1,0,0,0,0}
};

int[,] digit8 =
{
    {0,0,1,1,0,0},
    {0,1,0,0,1,0},
    {0,0,1,1,0,0},
    {0,1,0,0,1,0},
    {0,0,1,1,0,0}
};

int[,] digit9 =
{
    {0,0,1,1,0,0},
    {0,1,0,0,1,0},
    {0,0,1,1,1,0},
    {0,0,0,0,1,0},
    {0,0,1,1,0,0}
};


Console.Write("Введите число: ");
string num = Console.ReadLine();

int[,] number = nullMatrix;

for (int i = 0; i < num.Length; i++)
{
    int[,] figure = nullMatrix;
    if(num[i] == '0') figure = digit0;
    else if(num[i] == '1') figure = digit1;
    else if(num[i] == '2') figure = digit2;
    else if(num[i] == '3') figure = digit3;
    else if(num[i] == '4') figure = digit4;
    else if(num[i] == '5') figure = digit5;
    else if(num[i] == '6') figure = digit6;
    else if(num[i] == '7') figure = digit7;
    else if(num[i] == '8') figure = digit8;
    else if(num[i] == '9') figure = digit9;
    number = ComposeMatrices(number, figure);
}

ShowMatrix(number);