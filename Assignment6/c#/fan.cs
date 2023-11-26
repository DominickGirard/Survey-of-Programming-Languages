using System;

public class Fan
{
    // Properties
    public int Speed { get; set; }
    public double Radius { get; set; }
    public string Color { get; set; }

    // Default constructor
    public Fan()
    {
        Speed = 1;
        Radius = 1.53;
        Color = "green";
    }

    // Constructor with radius parameter
    public Fan(double newRadius)
    {
        Radius = newRadius;
    }

    // Method to return a string description of the fan
    public override string ToString()
    {
        return $"A {Radius:F2} inch {Color} fan at a speed of {Speed}";
    }
}
