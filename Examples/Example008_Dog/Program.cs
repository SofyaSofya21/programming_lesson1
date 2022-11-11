Console.WriteLine("Введите любое расстояние больше 10");
double distance = Convert.ToDouble(Console.ReadLine());

int count = 0;
double firstFriendSpeed = 1;
double secondFriendSpeed = 2;
double dogSpeed = 5;
int friend = 2;
double time;

Console.WriteLine("Вводные данные:");
Console.WriteLine($"Расстояние: {distance}");
Console.WriteLine($"Скорость первого друга = {firstFriendSpeed}, скорость второго друга = {secondFriendSpeed}");
Console.WriteLine($"Скорость собаки = {dogSpeed}, собака бежит от {friend}-го друга");

while(distance>10)
{
    if(friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}
Console.WriteLine($"Собака пробежит вот такое количество раз: {count}");