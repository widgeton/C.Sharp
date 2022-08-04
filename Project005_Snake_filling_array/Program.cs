int str, col,
    nulStr = 0, nulCol = 0,
    i = 0, j = 0,
    num = 1;

Console.Write("Введите количество строк: ");
str = Int32.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
col = Int32.Parse(Console.ReadLine());

int k = str, l = col;
int[,] arr = new int[str, col];


while(true){
    while(j<col)
    {
        arr[i, j] = num;
        num++;
        j++;
    }
    j--;
    num--;
    if(num==k*l) break;

    while(i<str)
    {
        arr[i, j] = num;
        num++;
        i++;
    }
    i--;
    num--;
    if(num==k*l) break;

    while(j>nulCol)
    {
        arr[i, j] = num;
        num++;
        j--;
    }
    if(num==k*l) break;


    while(i>nulStr)
    {
        arr[i, j] = num;
        num++;
        i--;
    }
    if(num==k*l) break;

    nulStr++;
    nulCol++;
    j=nulCol;
    i=nulStr;
    str--;
    col--;
    
}

for(int h = 0; h < k; h++)
{
    for(int g = 0; g < l; g++)
    {
        Console.Write(arr[h, g]+"\t");
    }
    Console.WriteLine();
}
Console.WriteLine();