int count = 0;
double distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
double time;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }

    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }

    distance -= (firstFriendSpeed + secondFriendSpeed) * time;

    //Console.WriteLine("Время: {0:#.####}", time);
    //Console.WriteLine("Расстояние: {0:#.####}", distance);
    //Console.WriteLine();

    count++;
}

Console.WriteLine("Собака пробежала {0} раз", count);