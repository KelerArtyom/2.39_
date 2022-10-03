using System;
public class Mainclass
{
    public static void Main()
    {
        double hour, min, sec, ang;
        Console.WriteLine("Введите количество часов:");
        hour = int.Parse(Console.ReadLine());
        if (hour >= 0 && hour <= 23)
        {
            Console.WriteLine("Введите количество минут:");
            min = int.Parse(Console.ReadLine());
            if (min >= 0 && hour <= 59) 
            {
                Console.WriteLine("Введите количество секунд:");
                sec = int.Parse(Console.ReadLine());
                if (sec >= 0 && sec <= 59) 
                {
                    ang = (hour * 15) + (min * 0.5) + (sec * 0.008);
                    Console.WriteLine($"Угол равен {ang} градусам");
                }
                else
                {
                    Console.WriteLine("Неверные данные");
                }
            }
            else
            {
                Console.WriteLine("Неверные данные");
            }
        }
        else
        {
            Console.WriteLine("Неверные данные");
        }
    }
}

