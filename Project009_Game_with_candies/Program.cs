// На столе лежит 2021 конфет. 
// Играет 2 игрока. За 1 ход игрок может забрать 1-19 конфет.
// Игрок забравший последнюю конфету - проигрывает и отдает другому игроку конфеты.
// за Второго игрока играет компьютер. Написание беспроигрышной для компьютера стратегии.


int candies = 81;

while(candies > 0)
{
    int num;
    if (candies > 1)
    {
        Console.Write($"Конфет на столе: {candies}. Ваш ход: ");
        num = int.Parse(Console.ReadLine());
    }
    else
    {
        Console.WriteLine($"Конфет на столе: {candies}. Вы проиграли!");
        break;
    }

    if(num < 1 || num > 19)
    {
        Console.WriteLine("Вы должны указать количество конфет в диапазоне от 1 до 19!");
        continue;
    }
    else candies -= num;

    Console.WriteLine($"Конфет на столе: {candies}. Ход компьютера: {20 - num}");
    candies = candies - (20 - num);

    Console.WriteLine();
}
Console.WriteLine();