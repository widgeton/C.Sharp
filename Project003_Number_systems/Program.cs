int num, i, j = 0;
int sys;
int[] arr = new int[10];

Console.Write("Введите систему исчисления числом (2, 8, 16): ");
sys = Int32.Parse(Console.ReadLine());

Console.Write("Введите число: ");
i = Int32.Parse(Console.ReadLine());

num = i;

do{
    arr[j] = i % sys;
    i = (i - arr[j]) / sys;
    j++;
}while(i > sys);
    
arr[j] = i;

Console.Write("Число {0} в {1}-ичной системе исчисления: ", num, sys);

while(j>=0)
{
    if(sys == 2 && arr[j] == 2)
    {
        Console.Write(10);
        j--;
        continue;
    };
        
    if(arr[j] < 10) Console.Write(arr[j]);
    switch(arr[j])
    {
        case 10:
            Console.Write('A');
            break;
        case 11:
            Console.Write('B');
            break;
        case 12:
            Console.Write('C');
            break;
        case 13:
            Console.Write('D');
            break;
        case 14:
            Console.Write('E');
            break;
        case 15:
            Console.Write('F');
            break;
    }
    j--;
};

Console.WriteLine();