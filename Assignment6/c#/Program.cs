using System;

class Program
{
    static void Main(string[] args)
    {
        Fan fan1 = new Fan
        {
            Speed = 3,
            Radius = 10.26,
            Color = "yellow"
        };
        Console.WriteLine(fan1);

        Fan fan2 = new Fan(5.79)
        {
            Speed = 2,
            Color = "blue"
        };
        Console.WriteLine(fan2);

        Fan fan3 = new Fan();
        Console.WriteLine(fan3);
    }
}
