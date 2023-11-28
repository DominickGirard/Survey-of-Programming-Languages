using System;
namespace Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            object fan1 = new Fan();
            fan1.Speed = 3;
            fan1.setRadius(10.26);
            fan1.setColor("yellow");
            Console.WriteLine(fan1);

            object fan2 = new Fan(5.79);
            fan1.setSpeed(2);
            fan1.setColor("blue");
            Console.WriteLine(fan2);

            object fan3 = new Fan();
            Console.WriteLine(fan3);
        }

    }
}